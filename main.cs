using System;

class Program {
  private const double CENTIMETERS_PER_INCH = 2.54;
  
   public static void Main (string[] args) {

   Console.WriteLine("Please Enter The Number Of Inches: ");
   var inputNumber = Console.ReadLine();
   double numberOfInches;
   
   if (double.TryParse(inputNumber, out numberOfInches)){
     Console.WriteLine("{0} inches is {1} centimeters.", numberOfInches, (numberOfInches * CENTIMETERS_PER_INCH));
     }
     else {
       Console.WriteLine("Please Input Numbers Only");
     }
  
  }
}