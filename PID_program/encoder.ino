//initialize interrupt on encoder pins
//-----------------------------------------------------------------------------------------
void encoderInit () {
  //init pin change interrupt on encoder pin A and B
  pinMode( ENCODER_A, INPUT_PULLUP );
  attachInterrupt( digitalPinToInterrupt( ENCODER_A ), encoderPulse, CHANGE );
  pinMode( ENCODER_B, INPUT_PULLUP);
  attachInterrupt( digitalPinToInterrupt( ENCODER_B ), encoderPulse, CHANGE );
}

void IRAM_ATTR encoderPulse () {
  //turn of interrupt, so we can finish the calcualtion before we leave the interrupt routine
  portENTER_CRITICAL_ISR ( &encoderInitMux );
  encoderState =  ( 0x0F & ( encoderState << 2 ) ) | ( ( 1 << digitalRead( ENCODER_A ) ) | digitalRead( ENCODER_B ));
 
  if ( 
       encoderState == 0x02 
    || encoderState == 0x04 
    || encoderState == 0x0B 
    || encoderState == 0x0D ){

    encoderDir = -1;
    encoderPos -= ENCODER_RESOLUTION;
  }

  else if ( 
       encoderState == 0x01 
    || encoderState == 0x07 
    || encoderState == 0x08 
    || encoderState == 0x0E  ) {

    encoderDir = 1;
    encoderPos += ENCODER_RESOLUTION;
  }

  //turn on interrupt
  portEXIT_CRITICAL_ISR ( &encoderInitMux );
}

