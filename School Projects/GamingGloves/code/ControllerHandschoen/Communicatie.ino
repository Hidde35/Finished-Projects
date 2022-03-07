String SerieelCommando = "";
bool communicatieGestart = false;

const char startKarakter = '#';
const char eindKarakter = '%';

int target = 0;

void sendInformation(char text[])
{
  Serial.print(startKarakter);
  Serial.print(text);
  Serial.println(eindKarakter);
}

void getInformation()
{
  if (Serial.available() > 0)
  {
    char readByte = Serial.read();
    if (readByte == startKarakter)
    {
      SerieelCommando = "";
      communicatieGestart = true;
    }
    else if (communicatieGestart)
    {
      if (readByte == eindKarakter)
      {
        communicatieGestart = false;
        HandleMessage (SerieelCommando);
      }
      else
      {
        SerieelCommando += readByte;
      }
    }
  }
}

void HandleMessage(String Message)
{
  if (Message.equals("D"))
  {
    target = 1;
  }
  else if (Message.equals("B"))
  {
    target = 2;
  }
}
