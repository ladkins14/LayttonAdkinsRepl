using System;

class Program {
  
   public static void Main (string[] args) {

   Console.WriteLine("Please Enter Message: ");
   var inputMessage = Console.ReadLine();
   
     //Next line reads the number of characters in the input string 
   int length = inputMessage.Length;

   if (length <= 140) {
    Console.WriteLine("Posted");
   }

   else if (length > 140) {
    Console.WriteLine("Rejected");
   }
  }
}