using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
class Program {
   public static void Main (string[] args) {

   string inputNumber;
   int rangeOfArray = 5;
   double averageRangeOfArray = 5.0;
   int totalOfTemps = 0;
   double averageTemp = 0;
   int ascendingPoints = 0;
   int descendingPoints = 0;

   // This line initializes an array with a variable for the range to use later
   int[] tempArray = new int[rangeOfArray];

   // This loop takes user inputs, checks if they're valid, and assigns them to the array
   for(int i = 0; i < rangeOfArray; i++) {

    do {

      Console.Write("Please Input Temperature {0}: ", i + 1);
      inputNumber = Console.ReadLine();

      if (Convert.ToInt16 (inputNumber) < -30 || Convert.ToInt16 (inputNumber) > 130 ) {

        Console.WriteLine("Temperature {0} is invalid, Please enter a valid temperature between -30 And 130", inputNumber);
        inputNumber = Console.ReadLine();

      }

    } while (!int.TryParse(inputNumber, out tempArray[i]));
   }

   // This loop determines if the elements in the array are decreasing or increasing and adds to a counter for each
   for(int i = 1; i < rangeOfArray; i++) {

    if (tempArray[i - 1] < tempArray[i]) {

      ascendingPoints++;

    }

    if (tempArray[i - 1] > tempArray[i]) {

      descendingPoints++;

    }
   }

   // This set of if statements check the counters and if one reaches 4 they display text for which one did, or displays text if neither did
   if (ascendingPoints == 4) {

    Console.WriteLine("Getting Warmer");

   }

   if (descendingPoints == 4) {

    Console.WriteLine("Getting Cooler");

   }

   if (ascendingPoints != 4 && descendingPoints != 4) {

    Console.WriteLine("It's a mixed bag");

   }

   // This for loop adds the values of each element in the array to a variable
   for (int i = 0; i < rangeOfArray; ++i) {

    totalOfTemps += tempArray[i];

   }

       Console.WriteLine("5-day Temperature [{0}, {1}, {2}, {3}, {4}]", tempArray[0], tempArray[1], tempArray[2], tempArray[3], tempArray[4]);

       // This calculates the average of the values entered to the array
       averageTemp = totalOfTemps / averageRangeOfArray; 

       Console.WriteLine("Average Temperature is {0} degrees", averageTemp);
     
 }
}
             
    


 


