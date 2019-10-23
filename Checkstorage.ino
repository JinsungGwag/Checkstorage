#include <SoftwareSerial.h>

// BLUETOOTH PIN
#define BT_RXD 8
#define BT_TXD 7
SoftwareSerial bluetooth(BT_RXD, BT_TXD);

// LED PIN
int ledPins[] = { 10, 9, 6, 5 };
int pinCount = 4;

// SENSOR PIN
#define TRIG 4
int echoPins[] = { 12, 11, 3, 2 };
int echoCount = 4;

int distance;
 
void setup(){
  Serial.begin(9600);
  bluetooth.begin(9600);

  pinMode(TRIG, OUTPUT);
  for(int i = 0; i < pinCount; i++)
  {
    pinMode(ledPins[i], OUTPUT);
    pinMode(echoPins[i], INPUT);
  }  
}
 
void loop(){
  if (bluetooth.available()) {
    Serial.write(bluetooth.read());
  }
  if (Serial.available()) {
    bluetooth.write(Serial.read());
  }

  for(int i = 0; i < echoCount; i++)
  {
    digitalWrite(TRIG, HIGH);
    delayMicroseconds(10);
    digitalWrite(TRIG, LOW);
  
    distance = pulseIn(echoPins[i], HIGH) / 58;
    Serial.print("ECHO");
    Serial.print(i + 1);
    Serial.print(": ");
    Serial.print(distance);
    Serial.print("cm    ");
  }
  Serial.println();
  delay(1000);
}
