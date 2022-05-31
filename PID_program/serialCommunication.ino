int16_t getValueFromSerial() {
  int8_t integerValue = 0;
  int8_t sign = 1;
  incomingByte = Serial.read();
  if ( incomingByte == 0x2D ) {
    sign = -1;
    incomingByte = Serial.read();
  }
  while (1) {
    if (incomingByte == 0x0A) break;
    integerValue *= 10;
    integerValue = ((incomingByte - 48) + integerValue);
    incomingByte = Serial.read();
  }
  return integerValue *= sign;
}


//Initialize timer that control how often serial data is sent to PC.
//------------------------------------------------------------------------------------------
void SerialTimerInit() {
  SerialTimerHW = timerBegin(1, 80, true);

  timerAttachInterrupt(SerialTimerHW, &SerialTimer, true);
  //timer is set to trigger with 25Hz
  timerAlarmWrite ( SerialTimerHW, 25000  , true );
  timerAlarmEnable ( SerialTimerHW );
}


//Toggle flagg that is used for timing of sending data to PC.
void IRAM_ATTR SerialTimer() {
  portENTER_CRITICAL_ISR ( &SerialTimerMux );
  SerialFlag = true;
  portEXIT_CRITICAL_ISR ( &SerialTimerMux );
}

void setValueFromSerial() {
  
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
 
