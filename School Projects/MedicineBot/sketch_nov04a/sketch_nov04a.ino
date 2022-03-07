#include <EVShield.h>
#include <Wire.h>
EVShield evshield(0x34, 0x36);

//code sensor
const int trigPin = 9; //pins voor sensor om te zoeken
const int echoPin = 10; //pins voor sensor om terug te sturen
long duration;

int kamer = 1;
int target;
int eersterit = 0;

//variables voor verlichting
int lampkamer3 = 12;
int lampkamer2 = 12;
int lampkamer1 = 11;

void setup() {
  pinMode(lampkamer3, OUTPUT); //lamp 3
  pinMode(lampkamer2, OUTPUT); //lamp 2
  pinMode(lampkamer1, OUTPUT); //lamp 1
  pinMode(trigPin, OUTPUT); //stelt de trigPin in als een output
  pinMode(echoPin, INPUT); //stelt de echoPin in als eem input

  Serial.begin(115200); //start Serial
  delay(2000);          //geef de seriele monitor tijd om op te starten

  evshield.init( SH_HardwareI2C );
  evshield.bank_a.motorReset(); //reset motoren
  evshield.bank_b.motorReset(); //reset motoren
}

void loop() {
  if (Serial.available() > 0)
  {
    char data = Serial.read();
    Serial.println(data);
    switch (data)
    {
      case 'A' : target = 1;
        break;
      case 'S' : target = 0;
        break;
      case 'B' : target = 2;
        break;
      case 'C' : target = 3;
    }
  }

  //van Kamer 2 naar kamer 1
  if (target == 1 && ( kamer == 2)) // als op knop gedrukt wordt gaat code runnen
  {
    Serial.println("ik rij van kamer 2 naar kamer 1");
    turn180degrees();
    distance();
    for (int s = 0; s < 4;)
    {
      forward(1);
      distance();
      s++;
      Serial.println(s);
      kamer = 1;
      while (distance() <= 40)
      {
        rgb();
        robotstop();
        rgb();
      }
    }
    lamp(lampkamer1);
  }

  //van kamer 3 naar kamer 1
  if (target == 1 && (kamer == 3))
  {
    Serial.println("ik rij van kamer 3 naar kamer 1");
    turn180degrees();
    distance();
    for (int s = 0; s < 4;)
    {
      forward(1);
      distance();
      s++;
      Serial.println(s);
      kamer = 1;
      while (distance() <= 40)
      {
        rgb();
        robotstop();
        rgb();
      }
    }
    lamp(lampkamer1);
  }

  //van kamer 1 naar kamer 2
  if (target == 2 && (kamer == 1))
  {
    Serial.println("ik rij van kamer 1 naar kamer 2");
    distance();
        if (eersterit != 0)
        {
          turn180degrees();
          delay(1000);
       }
    for (int s = 0; s < 4;)
    {
      forward(1);
      distance();
      s++;
      Serial.println(s);
      kamer = 2;
      while (distance() <= 40)
      {
        rgb();
        robotstop();
        rgb();
      }
    }
    eersterit = 1;
    lamp(lampkamer2);
  }

  if (target == 2 && (kamer == 3))
  {
    Serial.println("ik rij van kamer 3 naar kamer 2");
    turn180degrees();
    distance();
    for (int s = 0; s < 4;)
    {
      forward(1);
      distance();
      s++;
      Serial.println(s);
      kamer = 2;
      while (distance() <= 40)
      {
        rgb();
        robotstop();
        rgb();
      }
    }
    lamp(lampkamer2);
  }

  //van kamer 2 naar kamer 3
  if (target == 3 && (kamer == 2))
  {
    Serial.println("ik rij van kamer 2 naar kamer 3");
    turn180degrees();
    distance();
    for (int s = 0; s < 4;)
    {
      forward(1);
      distance();
      s++;
      Serial.println(s);
      kamer = 3;
      while (distance() <= 40)
      {
        rgb();
        robotstop();
        rgb();
      }
    }
    lamp(lampkamer3);
  }

  //van kamer 1 naar kamer 3
  if (target == 3 && (kamer == 1))
  {
    Serial.println("ik rij van kamer 1 naar kamer 3"); 
    distance();
        if (eersterit != 0)
        {
          turn180degrees();
          delay(1000); 
       }
    for (int s = 0; s < 4;)
    {
      forward(1);
      distance();
      s++;
      Serial.println(s);
      kamer = 3;
      while (distance() <= 40)
      {
        rgb();
        robotstop();
        rgb();
      }
    }
    lamp(lampkamer3);
    eersterit = 1;
  }

  if (target == 0)
  {
    robotstop();
  }
}


//robot voorruit
void forward(float secondes)
{
  evshield.bank_a.motorRunSeconds(SH_Motor_2,
                                  SH_Direction_Reverse,           //Richting
                                  SH_Speed_Medium,                //Snelheid
                                  secondes,                       //tijd
                                  SH_Completion_Dont_Wait,        //wel/niet wachten voor volgende actie
                                  SH_Next_Action_BrakeHold);
  evshield.bank_b.motorRunSeconds(SH_Motor_2,
                                  SH_Direction_Reverse,
                                  SH_Speed_Medium,
                                  secondes,
                                  SH_Completion_Dont_Wait,
                                  SH_Next_Action_BrakeHold); // miss SH_Next_Action_BrakeHold
  delay(1000);
}

//robot achteruit
void reverse(int secondes)
{
  evshield.bank_a.motorRunSeconds(SH_Motor_2,
                                  SH_Direction_Forward,
                                  SH_Speed_Medium,
                                  secondes,
                                  SH_Completion_Dont_Wait,
                                  SH_Next_Action_BrakeHold);
  evshield.bank_b.motorRunSeconds(SH_Motor_2,
                                  SH_Direction_Forward,
                                  SH_Speed_Medium,
                                  secondes,
                                  SH_Completion_Dont_Wait,
                                  SH_Next_Action_BrakeHold);
  delay(1000);
}

//robot naar links
void turn_left(double rotations)
{
  evshield.bank_b.motorRunSeconds(SH_Motor_2,
                                  SH_Direction_Forward,
                                  SH_Speed_Medium,
                                  rotations,
                                  SH_Completion_Dont_Wait,
                                  SH_Next_Action_BrakeHold);
  delay(1000);
}

//robot naar rechts
void turn_right(double rotations)
{
  evshield.bank_a.motorRunSeconds(SH_Motor_2,
                                  SH_Direction_Forward,
                                  SH_Speed_Medium,
                                  rotations,
                                  SH_Completion_Dont_Wait,
                                  SH_Next_Action_BrakeHold);
  delay(1000);
}

void turn180degrees()
{
  evshield.bank_a.motorRunSeconds(SH_Motor_2,
                                  SH_Direction_Forward,
                                  SH_Speed_Medium,
                                  1,
                                  SH_Completion_Wait_For,
                                  SH_Next_Action_BrakeHold);
  delay(1000);

  evshield.bank_b.motorRunSeconds(SH_Motor_2,
                                  SH_Direction_Reverse,
                                  SH_Speed_Medium,
                                  1,
                                  SH_Completion_Dont_Wait,
                                  SH_Next_Action_BrakeHold);
  delay(1000);
}


int distance()
{
  digitalWrite(trigPin, LOW); //reset de sensor
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  duration = pulseIn(echoPin, HIGH);
  return (duration * 0.034 / 2);
  delay(1000);
}


//lampjes aan en uit op EVShield
void rgb()
{
  evshield.ledSetRGB(255, 0, 0);   // licht aan op EVShield LED
  delay(1000);                // wait
  evshield.ledSetRGB(0, 0, 0);   // licht uit opEVShield LED.
  delay(1000);
}

//stopt de robot
void robotstop()
{
  evshield.bank_b.motorStop(SH_Motor_2,
                            SH_Next_Action_BrakeHold);
  evshield.bank_a.motorStop(SH_Motor_2,
                            SH_Next_Action_BrakeHold);
  delay(1000);
}

//lamp laten knipperen
void lamp(int lampkamer)
{
    digitalWrite(lampkamer, HIGH);
    delay(10000);
    digitalWrite(lampkamer, LOW);
}
