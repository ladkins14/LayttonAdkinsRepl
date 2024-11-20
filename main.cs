using System;

class Program {

  public static void Main (string[] args) {

  Int16 lastYearCont;
  Int16 thisYearCont;
  double thisYearRev;
  double lastYearRev;
  double ticketCost = 25;
  
  while(true) {
    Console.WriteLine("");
    Console.WriteLine("************************************");
    Console.WriteLine("*  The stars shine in Greenville.  *");
    Console.WriteLine("************************************");
    Console.WriteLine("Please Enter the following number below from the following menu: ");
    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit");

    string selectedOption = Console.ReadLine();

    //This if statement runs if the user selects "1", where it calculates the profits of this and last years comps and determines if this year's is bigger
    if (selectedOption == "1") {

    

      Console.Write("Number of Last Year's Contestants: ");
      lastYearCont = Int16.Parse(Console.ReadLine());

      //This if statement displays an error message if the number of last year contestants entered is not withing the selected range
      if (lastYearCont < 0 || lastYearCont > 30){

        Console.WriteLine("ERROR: contestant number must be between 0 and 30 (inclusive), please enter a valid number");
        
        Console.Write("Number of Last Year's Contestants: ");
        lastYearCont = Int16.Parse(Console.ReadLine());

      }

      Console.Write("Number of This Year's Contestants: ");
      thisYearCont = Int16.Parse(Console.ReadLine());

      //This if statement displays an error message if the number of this year contestants entered is not withing the selected range
      if (thisYearCont < 0 || thisYearCont > 30){

        Console.WriteLine("ERROR: contestant number must be between 0 and 30 (inclusive), please enter a valid number");
        
        Console.Write("Number of This Year's Contestants: ");
        thisYearCont = Int16.Parse(Console.ReadLine());

      }
    

      Console.WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", lastYearCont, thisYearCont);

      thisYearRev = thisYearCont * ticketCost;

      lastYearRev = lastYearCont * ticketCost;

      double twiceLastYearRev = lastYearRev * 2;

      Console.WriteLine("Revenue expected this year is ${0}", thisYearRev);

      // these if statements determine which competition will be bigger and displays it in one of three messages
      if (lastYearRev > thisYearRev) {


        Console.WriteLine("A tighter race this year! Come out and cast your vote!");

      }

      if (lastYearRev < thisYearRev && thisYearRev <= twiceLastYearRev) {

        Console.WriteLine("The competition is bigger than ever!");

      }

      if (lastYearRev < thisYearRev && thisYearRev > twiceLastYearRev) {

        Console.WriteLine("The competition is more than twice as big this year!");

      }
    }
    
    // this if statement runs if the user selects "2", where it displays a goodbye message and closes the program
    if (selectedOption == "2") {

      Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");

      break;
    }
   }

   }

   }


    


 


