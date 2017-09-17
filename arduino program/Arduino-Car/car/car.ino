class car
{
  public:
    uint8_t pin1 = 4;
    uint8_t pin2 = 5;
    uint8_t pin3 = 6;
    uint8_t pin4 = 7;

    uint8_t enable1 = 3;
    uint8_t enable2 = 9;

    byte Speed = 130;
    bool Dir = 0;

    char val;
    car(uint8_t pin1, uint8_t pin2, uint8_t pin3, uint8_t pin4, uint8_t enable1, uint8_t enable2)
    {
      this->pin1 = pin1;
      this->pin2 = pin2;
      this->pin3 = pin3;
      this->pin4 = pin4;

      this->enable1 = enable1;
      this->enable2 = enable2;
    }

    void SetupCar()
    {
      pinMode(pin1, OUTPUT);
      pinMode(pin2, OUTPUT);
      pinMode(pin3, OUTPUT);
      pinMode(pin4, OUTPUT);
      pinMode(enable1, OUTPUT);
      pinMode(enable2, OUTPUT);
    }

    void Go(byte Speed)
    {
      analogWrite(enable1, Speed);
      analogWrite(enable2, Speed);
      digitalWrite(pin1, LOW);
      digitalWrite(pin2, HIGH);
      digitalWrite(pin3, LOW);
      digitalWrite(pin4, HIGH);
    }
    void GoBack(byte Speed)
    {
      analogWrite(enable1, Speed);
      analogWrite(enable2, Speed);
      digitalWrite(pin1, HIGH);
      digitalWrite(pin2, LOW);
      digitalWrite(pin3, HIGH);
      digitalWrite(pin4, LOW);
    }

    void Stop()
    {
      analogWrite(enable1, 0);
      analogWrite(enable2, 0);
      digitalWrite(pin1, LOW);
      digitalWrite(pin2, LOW);
      digitalWrite(pin3, LOW);
      digitalWrite(pin4, LOW);
    }

    void TurnRight(byte Speed)
    {
      analogWrite(enable1, Speed);
      analogWrite(enable2, Speed);
      digitalWrite(pin1, LOW);
      digitalWrite(pin2, HIGH);
      digitalWrite(pin3, HIGH);
      digitalWrite(pin4, HIGH);
    }

    void BackRight(byte Speed)
    {
      analogWrite(enable1, Speed);
      digitalWrite(pin1, HIGH);
      digitalWrite(pin2, LOW);

      analogWrite(enable2, Speed);
      digitalWrite(pin3, HIGH);
      digitalWrite(pin4, HIGH);
    }

    void TurnLeft(byte Speed)
    {
      analogWrite(enable1, Speed);
      analogWrite(enable2, Speed);
      digitalWrite(pin1, HIGH);
      digitalWrite(pin2, HIGH);
      digitalWrite(pin3, LOW);
      digitalWrite(pin4, HIGH);
    }

    void BackLeft(byte Speed)
    {
      analogWrite(enable1, Speed);
      digitalWrite(pin1, HIGH);
      digitalWrite(pin2, HIGH);

      analogWrite(enable2, Speed);
      digitalWrite(pin3, HIGH);
      digitalWrite(pin4, LOW);
    }
    void message()
    {
      if (val == 'F')
      {
        Go(Speed);
        Dir = false;
      }
      if (val == 'R' && Dir == 0)
      {
        TurnRight(Speed);
      }
      if (val == 'R' && Dir == 1)
      {
        BackRight(Speed);
      }

      if (val == 'L' && Dir == 0)
      {
        TurnLeft(Speed);
      }
      if (val == 'L' && Dir == 1)
      {
        BackLeft(Speed);
      }

      if (val == 'S')
      {
        Stop();
      }
      if (val == 'B')
      {
        GoBack(Speed);
        Dir = true;
      }
    }
};
car mert(5, 4, 6, 7, 3,9);

void setup() {
  mert.SetupCar();
  Serial.begin(9600);
}

void loop() {
  if (Serial.available() > 0)
  {
    mert.val = Serial.read();
    mert.message();
  }
}
