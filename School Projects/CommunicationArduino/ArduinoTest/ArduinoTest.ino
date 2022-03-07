void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
}
int x = 0;
void loop() {
  // put your main code here, to run repeatedly:
  Serial.print("#");
  Serial.print(x);
  Serial.println("%");
  x++;
  delay(1000);
}
