using System;

class Program {
  private const double CENTIMETERS_PER_INCH = 2.54;
  
   public static void Main (string[] args) {
   double measureInInches = 15994;
   double total = measureInInches * CENTIMETERS_PER_INCH;
   Console.WriteLine ("{0} inches is {1} centimeters.", measureInInches, total);
  
  }
}