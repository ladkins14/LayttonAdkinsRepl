using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
class Program {
   public static void Main (string[] args) {

    string inputInitial;
    double dSaleAmount = 0;
    double eSaleAmount = 0;
    double fSaleAmount = 0;
    double totalSaleAmount;
    Char highestSale = 'z';

    string[] salesPersonNames = { "Danielle", "Edward", "Francis" };
    string[] allowedInitials = {"D", "E", "F", "d", "e", "f", "Z", "z" };

    //This array will hold the values of the sales each salesperson made, going from Danielle, to Edward, to Francis
    double[] accumSales = new double[3];
    
    while (true) {

      Console.Write("Please Enter Salesperson Initial or Z To Quit: ");
      inputInitial = Console.ReadLine();

      //This if statement displays an error message if the input is not one of the allowed initials or the exit case
      if (!allowedInitials.Contains(inputInitial)) {

        Console.WriteLine("Error, invalid salesperson selected, please try again");
        inputInitial = Console.ReadLine();

      }

        //This if statement runs if the entered initial is equal to "D" or "d" in the array
        if (inputInitial == allowedInitials[0] || inputInitial == allowedInitials[3]) {

          Console.Write("Enter Sale Amount: ");

          dSaleAmount = double.Parse(Console.ReadLine());

          //This statement adds the amount of Danielle's sale to the first element of the accumSales array
          accumSales[0] += dSaleAmount;

        }

          //This if statement runs if the entered initial is equal to "E" or "e" in the array
          if (inputInitial == allowedInitials[1] || inputInitial == allowedInitials[4]) {

            Console.Write("Enter Sale Amount: ");

          eSaleAmount = double.Parse(Console.ReadLine());

          //This statement adds the amount of Edward's sale to the second element of the accumSales array
          accumSales[1] += eSaleAmount;

          }

            //This if statement runs if the entered initial is equal to "F" or "f" in the array
            if (inputInitial == allowedInitials[2] || inputInitial == allowedInitials[5]) {

              Console.Write("Enter Sale Amount: ");

              fSaleAmount = double.Parse(Console.ReadLine());

              //This statement adds the amount of Francis' sale to the third element of the accumSales array
              accumSales[2] += fSaleAmount;
            }

              //These three if statements determine which salesperson had the highest sale
              if (dSaleAmount > eSaleAmount && dSaleAmount > fSaleAmount) {
              highestSale = 'D';
            }

                if (eSaleAmount > dSaleAmount && eSaleAmount > fSaleAmount){
                  highestSale = 'E';
              }

                  if (fSaleAmount > dSaleAmount && fSaleAmount > eSaleAmount){
                    highestSale = 'F';
                }

                    //This if statement is the exit condition and calculates the total sales and displays it and the top seller
                    if (inputInitial == allowedInitials[6] || inputInitial == allowedInitials[7]) {

                      totalSaleAmount = accumSales[0] + accumSales[1] + accumSales[2];
                      Console.WriteLine("Grand Total: {0}", totalSaleAmount);
                      Console.WriteLine("Highest Sale: {0}", highestSale);
                      break;
                    }
        
      }
             
    }

 }


