using System;
using System.Data;
using System.Linq;
using System.Windows.Markup;
using System.Xml.Schema;

class Program {
  
   public static void Main (string[] args) {

  int enteredNumber;

  int sum = 0;

  int divisionResult;

   Console.Write("Please Enter A Number: ");

   enteredNumber = int.Parse(Console.ReadLine());

   divisionResult = enteredNumber;

   for (int i = 1; i < enteredNumber; i++) {

    if (enteredNumber % i == 0) {

      sum = sum + i;

    }
   }

   if (sum == divisionResult) {

    Console.WriteLine("Perfect Number");

   }

   else {

    Console.WriteLine("Not A Perfect Number");

   }

 }

}
