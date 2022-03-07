int CHECKTIME = 10;
unsigned long lastMillis = 0;

void InitializeMPU()
{
  //checkt of de accelerosensor er goed in zit
  sendInformation("Initialize MPU6050");
  while (!mpu.begin(MPU6050_SCALE_2000DPS, MPU6050_RANGE_2G))
  {
    sendInformation("Could not find a valid MPU6050 sensor, check wiring!");
    delay(500);
  }
}

void GiveCommand()
{
  Vector rawAccel = mpu.readRawAccel(); //leest de richting
  if (millis() - lastMillis >= CHECKTIME)
  {
    lastMillis = millis();
    /*
         //checkt de gegevens van de sensor om richtingen in te stellen
         sendInformation("");
         sendInformation(" X = " + rawAccel.XAxis);
         sendInformation(" Y = " + rawAccel.YAxis);


         //checkt de snelheid
         sendInformation(" Z = " + rawAccel.ZAxis);
    */
    //attack
    if (rawAccel.ZAxis >= 30000) //attack
    {
      sendInformation("ATTACK");
      CHECKTIME = 800;
    }

    //lopen
    else if (rawAccel.YAxis <= 54500 && rawAccel.YAxis >= 50000 && sprint == 0) //naar voren
    {
      sendInformation("V");
      CHECKTIME = 200;
    }
    else if (rawAccel.YAxis <= 13000 && rawAccel.YAxis >= 5000 && sprint == 0) //naar achter
    {
      sendInformation("A");
      CHECKTIME = 200;
    }
    else if (rawAccel.XAxis <= 15000 && rawAccel.XAxis >= 10000 && sprint == 0) //naar links
    {
      sendInformation("L");
      CHECKTIME = 200;
    }
    else if (rawAccel.XAxis >= 50000 && rawAccel.XAxis <= 56000 && sprint == 0) //naar rechts
    {
      sendInformation("R");
      CHECKTIME = 200;
    }

    //sprinten
    else if (rawAccel.YAxis <= 54500 && rawAccel.YAxis >= 50000 && sprint == 1) //naar voren
    {
      sendInformation("SV");
      CHECKTIME = 200;
    }
    else if (rawAccel.YAxis <= 13000 && rawAccel.YAxis >= 5000 && sprint == 1) //naar achter
    {
      sendInformation("SA");
      CHECKTIME = 200;
    }
    else if (rawAccel.XAxis <= 15000 && rawAccel.XAxis >= 10000 && sprint == 1) //naar links
    {
      sendInformation("SL");
      CHECKTIME = 200;
    }
    else if (rawAccel.XAxis >= 50000 && rawAccel.XAxis <= 56000 && sprint == 1) //naar rechts
    {
      sendInformation("SR");
      CHECKTIME = 200;
    }
  }
}
