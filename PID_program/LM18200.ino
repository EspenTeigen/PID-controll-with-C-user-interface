//See datasheet of H-bridge
//Find out if motor is positioned in positiv or negative angle relative to 0

void H_BridgeInit() {
  pinMode(DIR_PIN, OUTPUT);
  digitalWrite(DIR_PIN, LOW);

  pinMode(BREAK_PIN, OUTPUT);
  digitalWrite(BREAK_PIN, LOW);

  pinMode(PWM_PIN, OUTPUT);
  digitalWrite(PWM_PIN, HIGH);
}

void motorDir(double _angle) {
  if ( _angle > PIDSetPoint ) {
    digitalWrite(DIR_PIN, HIGH);
  }
  else if ( _angle < PIDSetPoint) {
    digitalWrite(DIR_PIN, LOW);
  }
}


