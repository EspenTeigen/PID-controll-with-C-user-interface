#include "Arduino.h"
#include "PID.h"


void PID::setConstants ( double _kp, double _ki, double _kd ) {
      kp = _kp;
      //Calculate so the constants maches sample time.
      ki = _ki * sampleTime;
      kd = _kd * sampleTime;
    }

void PID::setKp (double _kp) {
      kp = _kp;

    }
void PID::setKi (double _ki) {
      ki = _ki * sampleTime;
    }
void PID::setKd (double _kd) {
      kd = _kd * sampleTime;
    }
	
void PID::setLimits( int _minimum, int _maximum ) {
      maximum = (double)_maximum;
      minimum = (double)_minimum;
    }

void PID::setFrequency(uint16_t frequency ) {
      sampleTime = (double) 1 / frequency;
      ki = ki * sampleTime;
      kd = kd * sampleTime;    
    }

double PID::compute(double setPoint, double input) {
      
	  //Deres kode her
	  
      return output;
    }
