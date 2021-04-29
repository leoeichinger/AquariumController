// Uduino settings
#include <Uduino_Wifi.h>
Uduino_Wifi uduino("80LNano"); // Declare and name your object

IPAddress ip(192, 168, 11, 11);
IPAddress gateway(192, 168, 0, 1);
IPAddress subnet(255, 255, 255, 0);

void setup()
{
  Serial.begin(115200);

  uduino.setStaticIP(ip, gateway , subnet );
  uduino.connectWifi("cablelink_0472368", "ujD83F3ez3i-Pd;X");
}

void loop()
{
  uduino.update();

  if (uduino.isConnected()) {

  }
}

void printValue(int pin, int targetValue) {
  uduino.print(pin);
  uduino.print(" "); //<- Todo : Change that with Uduino delimiter
  uduino.println(targetValue);
}

void ReadAnalogPin() {
  int pinToRead = -1;
  char *arg = NULL;
  arg = uduino.next();
  if (arg != NULL)
  {
    pinToRead = atoi(arg);
    if (pinToRead != -1)
      printValue(pinToRead, analogRead(pinToRead));
  }
}
