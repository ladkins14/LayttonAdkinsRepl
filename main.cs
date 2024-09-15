using System;

class Program {
  private const decimal BASE_RATE = 200;
  private const decimal PER_HOUR = 150;
  private const decimal PER_MILE = 2;
  
   public static void Main (string[] args) {

   Console.WriteLine("Please Enter The Number Of Hours For Job: ");
   var inputHours = Console.ReadLine();
     
   Console.WriteLine("Please Enter The Number Of Miles: ");
   var inputMiles = Console.ReadLine();
     
   decimal numberOfHours;
   decimal numberOfMiles;
   
   if (decimal.TryParse(inputHours, out numberOfHours) && decimal.TryParse(inputMiles, out numberOfMiles)) {
     Console.WriteLine("Estimated Total Moving Fee is ${0}", (BASE_RATE + (PER_HOUR * numberOfHours) + (PER_MILE * numberOfMiles)));
     }
     else {
       Console.WriteLine("Please Input Numbers Only");
     }
  
  }
}