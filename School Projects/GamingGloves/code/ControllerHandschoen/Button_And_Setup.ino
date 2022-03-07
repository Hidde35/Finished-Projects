void CheckButton()
{
  buttonState = digitalRead(buttonPin);
  if (buttonState == HIGH && sprint == 0)
  {
    sendInformation("sprintOn");
    sprint = 1;
    buttonState = LOW;
    delay(500);
  }
  if (buttonState == HIGH && sprint == 1)
  {
    sendInformation("sprintOff");
    sprint = 0;
    buttonState = LOW;
    delay(500);
  }
}
