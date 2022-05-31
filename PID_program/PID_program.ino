#include <math.h>
#include <driver/adc.h>
#include <PID.h>

//H_bridge configuration constants
//------------------------------------------------------------------------------

#define DIR_PIN 12
#define BREAK_PIN 27
#define THERMAL_FLAG_PIN 33
#define PWM_PIN 13                               //Speed control of motor

#define PWM_CHANNEL 0                            //Internal reference to PWM-register in microcontroller
#define PWM_FREQ 10000                            //Frequency of the PWM-signal
#define PWM_RES 10                               //Bit-resolution on PWM-signal
#define PWM_BITS 1024
//-------------------------------------------------------------------------------

#define GET_VOLTAGE_POT adc1_get_voltage(ADC1_CHANNEL_0)


//Rotary encoder configuration constants
//-------------------------------------------------------------------------------
#define ENCODER_A 32                             //Input Pin A on encoder
#define ENCODER_B 15                             //Input pin B on encoder
#define ENCODER_START_POS 0
const double ENCODER_RESOLUTION = 0.6;            //degrees
//----------------------------------------------------------------


//----------------------Rotary encoder variables------------------

volatile uint8_t encoderState = 0;                //Variable that holds the current and previous position
volatile double encoderPos = ENCODER_START_POS;   //Start position of encoder
volatile int8_t encoderDir;                      //Direction of rotation of encoder


//---------------------PID variables----------------------------

volatile bool PIDFlag = false;
double pidValue;
int16_t PIDSetPoint;

//------------------Serial communcation variables---------------
volatile bool SerialFlag = false;
char incomingByte;

//----------Toggle switch used for choosing use of potmeter-----
bool potOrPC = false;


//---------------Position calcualtion variables-----------------
volatile double posAnalog = 0;
double posAnalogLast = 0;



//----------------Interrupt handlers----------------------------

//encoder
portMUX_TYPE encoderInitMux = portMUX_INITIALIZER_UNLOCKED;

//timer interrupt pid-calculation
portMUX_TYPE PIDTimerMux = portMUX_INITIALIZER_UNLOCKED;
hw_timer_t * PIDTimerHW = NULL;

//timer interrupt serial data out
portMUX_TYPE SerialTimerMux = portMUX_INITIALIZER_UNLOCKED;
hw_timer_t * SerialTimerHW = NULL;


//--------Function declarations--------------------------------
void IRAM_ATTR encoderPulse();
void IRAM_ATTR PIDTimer();
void IRAM_ATTR SerialTimer();
void encoderInit();
void pwmInit();
void SerialTimerInit();
void pidInit();
void motorDir(double _angle);
void initPIDSamplingFrequency();
int16_t getValueFromSerial();
void adcInit();
void setPIDSamplingFrequency(char _frequency);


//-----------Create a PID object------------
PID pid;

void setup() {
  pidInit();
  setPIDSamplingFrequency(100);
  pid.setLimits(-PWM_BITS, PWM_BITS);
  pid.setConstants(14, 50, 100);

  encoderInit();
  H_BridgeInit();
  SerialTimerInit();
  pwmInit();
  adcInit();
  //read and save the position of the potmeter

  posAnalog = (double)map(GET_VOLTAGE_POT, 0, 4095, 100, -100);
  posAnalogLast = posAnalog;
  //Start serial communication
  Serial.begin(115200);
}

void loop() {

  //PIDFlagg is toggled as often as the PID frequency ISR is set
  if (PIDFlag == true) {
    //Set motor direction 
    motorDir(encoderPos);
    //Calculate PID
    pidValue = pid.compute(PIDSetPoint, encoderPos);
    //Write PWM value to pwm pin on H-bridge
    ledcWrite(PWM_CHANNEL, abs(pidValue));
    //Reset flagg
    PIDFlag = false;
  }

  //SerialFlagg is toggled as often as the Serial timer ISR is set
  if (SerialFlag == true) {
    //Map and save position of potmeter
    posAnalog = map(GET_VOLTAGE_POT, 0, 4095, 100, -100);
    //Send real time data to PC
    Serial.print(String("o") +  encoderPos + String("i") + pidValue + String("l") + PIDSetPoint + String("\n"));
    //Reset flag
    SerialFlag = false;

  }
  //Smoothing of analogValues from potmeter if use of potmeter is selected
  if ( ( (posAnalog > posAnalogLast + 1) || (posAnalog < posAnalogLast - 1) ) && ( potOrPC == true) ) {
    posAnalogLast = posAnalog;
    PIDSetPoint = posAnalog;
  }

  //If it is data in the serial register
  if (Serial.available() > 0) {
   
    incomingByte = Serial.read();

    switch (incomingByte) {
      case 's':
        PIDSetPoint = getValueFromSerial();
        break;

      case 'p':
        pid.setKp((double)getValueFromSerial());
        break;

      case 'i':
        pid.setKi((double)getValueFromSerial());
        break;

      case 'd':
        pid.setKd((double)getValueFromSerial());
        break;

      case 'f':
        setPIDSamplingFrequency((double)getValueFromSerial());
        break;
      case 't':
        if (getValueFromSerial() == 1) potOrPC = true;
        else potOrPC = false;
        break;
    }
  }
}




