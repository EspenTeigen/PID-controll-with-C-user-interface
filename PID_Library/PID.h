#ifndef PID_h
#define PID_h

#include "Arduino.h"

class PID {
	private:
		double lastInput;
		double maximum, minimum;
		double sampleTime;
		double kp, ki, kd;
		double output;
		
	public:
		void setConstants( double _kp, double _ki, double _kd );
		void setKp(double _kp);
		void setKi(double _ki);
		void setKd(double _kd); 
		void setLimits( int _minimum, int _maximum );
		void setFrequency(uint16_t frequency );
		double compute(double setPoint, double input);		
};

#endif