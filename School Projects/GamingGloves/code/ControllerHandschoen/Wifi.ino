
//////invullen gegevens wifi:
char ssid[] = "12connect";       // netwerk SSID (naam)
int status = WL_IDLE_STATUS;     // the WiFi radio's status

void InitializeWifi()
{
  // verbind met de wifi:
  while ( status != WL_CONNECTED) {
    sendInformation("Attempting to connect to open SSID: ");
    sendInformation(ssid);
    status = WiFi.begin(ssid);
    // wait 10 seconds for connection:
    delay(10000);
  }

  // Je bent verbonden met de wifi:
  sendInformation("Je bent verbonden met het netwerk: ");
  sendInformation(ssid);
}
