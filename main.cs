using System;
class Program {
   public static void Main (string[] args) {

    Char initial;
    string inputInitial;
    double dSaleAmount = 0;
    double eSaleAmount = 0;
    double fSaleAmount = 0;
    double totalSaleAmount = 0;
    Char highestSale = 'z';

    while (true) {
      Console.Write("Please Enter Salesperson Initial or Z To Quit: ");

      inputInitial = Console.ReadLine();
      //Next Line Converts user input into a character data type
      initial = Convert.ToChar(inputInitial);

      //This if statement displays an error message if the initial is not recognized
      if (Char.ToUpper(initial) != 'D' && Char.ToUpper(initial) != 'E' && Char.ToUpper(initial) != 'F' && Char.ToUpper(initial) != 'Z') {
        Console.WriteLine("Error, invalid salesperson selected, please try again");

        inputInitial = Console.ReadLine();
        initial = Convert.ToChar(inputInitial);
      }

      //The next three if statements determine each salespersons sales based on the initial entered and user input
        if (Char.ToUpper(initial) == 'D') {

          Console.WriteLine("Enter Sale Amount: ");

          dSaleAmount = double.Parse(Console.ReadLine());

          totalSaleAmount = totalSaleAmount + dSaleAmount;
        }

          if (Char.ToUpper(initial) == 'E') {

            Console.WriteLine("Enter Sale Amount: ");

            eSaleAmount = double.Parse(Console.ReadLine());

            totalSaleAmount = totalSaleAmount + eSaleAmount;
          }

           if (Char.ToUpper(initial) == 'F') {

            Console.WriteLine("Enter Sale Amount: ");

            fSaleAmount = double.Parse(Console.ReadLine());

            totalSaleAmount = totalSaleAmount + fSaleAmount;
           }

            //These three if statements determine which salesperson made the most
            if (dSaleAmount > eSaleAmount && dSaleAmount > fSaleAmount) {
              highestSale = 'D';
            }

              if (eSaleAmount > dSaleAmount && eSaleAmount > fSaleAmount){
                  highestSale = 'E';
              }

                if (fSaleAmount > dSaleAmount && fSaleAmount > eSaleAmount){
                    highestSale = 'F';
                }

                  //This if statement is the exit condition and displays the total sales and the top seller
                  if (Char.ToUpper(initial) == 'Z') {

                    Console.WriteLine("Grand Total: {0}", totalSaleAmount);
                    Console.WriteLine("Highest Sale: {0}", highestSale);
                    break;
                  }
             
    }

 }

}
