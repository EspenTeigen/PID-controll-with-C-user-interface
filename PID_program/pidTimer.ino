
void setPIDSamplingFrequency(char _frequency) {
  pid.setFrequency(_frequency);
  timerAlarmWrite ( PIDTimerHW, 1000000 / _frequency , true );
  timerAlarmEnable ( PIDTimerHW );
}

void pidInit () {
  //init timer interrupt for encoder timing, use timer 0, prescaler 80 and true=count up
  PIDTimerHW = timerBegin( 0, 80, true );
  timerAttachInterrupt( PIDTimerHW, &PIDTimer, true );
}

//Toggle flagg that is used to time the calculation of PID value
//-----------------------------------------------------------------------------------------
void IRAM_ATTR PIDTimer () {
  portENTER_CRITICAL_ISR ( &PIDTimerMux );
  PIDFlag = true;
  portEXIT_CRITICAL_ISR ( &PIDTimerMux );
}
//------------------------------------------------------------------------------------------

