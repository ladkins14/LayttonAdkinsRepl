using System;
using System.Data;
using System.Linq;
using System.Windows.Markup;
using System.Xml.Schema;

class Program {
  
   public static void Main (string[] args) {

   Console.WriteLine("Please Enter Wind Speed: ");
   // The .Split splits the users input from including both the value and the unit so the program can use the value
   var inputWindSpeed = Console.ReadLine().Split();
   // This line identifies the number part of the input
   string input = string.Concat( inputWindSpeed.Where (Char.IsDigit));
   // This line turns the input from a string into an integer/decimal
   decimal outputInfo = decimal.Parse(input);

   if (outputInfo >= 157) {
    Console.WriteLine("Category Five Hurricane");
   }

   else if (outputInfo >= 130) {
    Console.WriteLine("Category Four Hurricane");
   }

   else if (outputInfo >= 111) {
    Console.WriteLine("Category Three Hurricane");
   }

   else if (outputInfo >= 96) {
    Console.WriteLine("Category Two Hurricane");
   }

   else if (outputInfo >= 74) {
    Console.WriteLine("Category One Hurricane");
   }
   else {
    Console.WriteLine("Not a Hurricane");
   }

 }

}
