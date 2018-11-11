#include<Servo.h>
Servo s1;
volatile int flow_frequency; // Measures flow sensor pulses
unsigned int l_hour; // Calculated litres/hour
unsigned char flowsensor = 2; // Sensor Input
unsigned long currentTime;
unsigned long cloopTime;
int maxl_hour = 800;
int minl_hour = 250;
int RedLed = 3;
int YellowLed = 4;
int Buzzer = 5;

void flow () // Interrupt function
{
   flow_frequency++;
}
void setup()
{
   pinMode(flowsensor, INPUT);
   digitalWrite(flowsensor, HIGH); // Optional Internal Pull-Up
   Serial.begin(9600);
   attachInterrupt(0, flow, RISING); // Setup Interrupt
   sei(); // Enable interrupts
   currentTime = millis();
   cloopTime = currentTime;
   pinMode(YellowLed, OUTPUT);
   pinMode(Buzzer, OUTPUT);
   s1.attach (7);
   
}
void loop ()
{
   currentTime = millis();
   // Every second, calculate and print litres/hour
   if(currentTime >= (cloopTime + 1000))
   {
      cloopTime = currentTime; // Updates cloopTime
      // Pulse frequency (Hz) = 7.5Q, Q is flow rate in L/min.
      l_hour = (flow_frequency * 60 / 7.5); // (Pulse frequency x 60 min) / 7.5Q = flowrate in L/hour
      flow_frequency = 0;
      Serial.print(l_hour, DEC); // Print litres/hour
      Serial.println(" L/hour");

      if(l_hour >=maxl_hour)
      {
        digitalWrite(YellowLed, HIGH);
        digitalWrite(Buzzer, LOW);
        //digitalWrite(Buzzer, HIGH);
        Serial.println("High flow rate, system decrease the flow or supply of water");
        s1.write (150);         
    
        
       
      }
      else if(l_hour <= minl_hour&& l_hour>0)
      {
        digitalWrite(RedLed, HIGH);
        digitalWrite(Buzzer, HIGH);
        //digitalWrite(Buzzer, LOW);//di to totoo
        digitalWrite(YellowLed, LOW);
        Serial.println(" Your System has been Shutdown because of a possible leakage in Pipe ");
        s1.write (180);        
       
      }
      else{
        digitalWrite(YellowLed, LOW);
        digitalWrite(RedLed, LOW);
        digitalWrite(Buzzer, LOW);
         
        
      }
      
   }
}
