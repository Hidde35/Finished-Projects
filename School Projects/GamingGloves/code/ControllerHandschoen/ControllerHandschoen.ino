//Libraries
#include <SPI.h>
#include <WiFi101.h>
#include "arduino_secrets.h"
#include <Wire.h>
#include <MPU6050.h>
#include "pitches.h"
MPU6050 mpu;

//setup voor button
int buttonPin = 6;
int buttonState = 0;
int sprint = 0;;

void setup() {
  //opent de serial:
  Serial.begin(115200);
  while (!Serial) {
    ; // delay die wacht tot de serial klaar is
  }

  pinMode(buttonPin, INPUT);

  //Verbind met wifi
  //InitializeWifi();
  
  //checkt of de MPU sensor goed is aangesloten en of hij werkt.
  InitializeMPU();
}

void loop() {
  //kijkt of er iets binnen komt in C#
  getInformation();
  //checkt of er op de knop wordt gedrukt, zoja: verander sprint naar lopen of andersom.
  CheckButton();
  //Meet de MPU6050 AcceleroSensor en geeft informatie door naar C#
  GiveCommand();
  //Checkt of hij een van de melodiën af moet spelen en speelt deze af:
  deadMelodie();
  bumpWall();

}
