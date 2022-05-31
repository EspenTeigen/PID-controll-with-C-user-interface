//Initialize ADC
void adcInit() {
  adc1_config_width(ADC_WIDTH_12Bit);
  adc1_config_channel_atten(ADC1_CHANNEL_0, ADC_ATTEN_11db);
}

//initialize pwm.
//-----------------------------------------------------------------------------------------
void pwmInit () {
  ledcSetup ( PWM_CHANNEL, PWM_FREQ, PWM_RES );
  ledcAttachPin (PWM_PIN, PWM_CHANNEL );
}


