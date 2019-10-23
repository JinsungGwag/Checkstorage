#include <SoftwareSerial.h>

// BLUETOOTH PIN
#define BT_RXD 8
#define BT_TXD 7
SoftwareSerial bluetooth(BT_RXD, BT_TXD);

// LED PIN
#define LED1 10
#define LED2 9
#define LED3 6
#define LED4 5

// SENSOR PIN
#define TRIG 4
#define ECHO1 12
#define ECHO2 11
#define ECHO3 3
#define ECHO4 2

 
void setup(){
  Serial.begin(9600);
  bluetooth.begin(9600);
}
 
void loop(){
  if (bluetooth.available()) {
    Serial.write(bluetooth.read());
  }
  if (Serial.available()) {
    bluetooth.write(Serial.read());
  }
}
