using System;
using TheBakery.Models;


namespace TheBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("-----------------------------------------------------------------------");
      Console.WriteLine("|");
      Console.WriteLine("|               -- Welcome to Pierre's Bakery! --");
      Console.WriteLine("|   Our baked goods are great and our specials will keep you coming back for more ");
      Console.WriteLine("|");
      Console.WriteLine("|------------------------------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("|");
      Console.WriteLine("|  Bread is $5 per loaf and if you buy 2, you can get a 3rd loaf for free!");
      Console.WriteLine("|  For pastries we have Cinnamon Rolls, they're $2, or you can get 3 for $5  -----  Recommended by kids!");
      Console.WriteLine("|");
      Console.WriteLine("|------------------------------------------------------------------------");
      Console.WriteLine("|");
      Console.WriteLine("|");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("|  Would you like some bread or a pastry?  Yes or No");
      Console.Write("|  ");
      string yesOrNo = Console.ReadLine().ToLower();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("| ---------------------------------------------------------------------");
      Console.WriteLine("| ---------------------------------------------------------------------");
      Console.WriteLine("| ---------------------------------------------------------------------");
      Console.WriteLine("|");
      
      if (yesOrNo == "yes" || yesOrNo == "y")
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("|  How many loaves of bread would you like today:  ");
        int HowManyLoaves = int.Parse(Console.ReadLine());
        Console.WriteLine(" --  &  -- ");
        Console.Write("|  And any cinnamon roll pastries?:  ");
        int HowManyRolls = int.Parse(Console.ReadLine());
        Console.WriteLine("| -------------------------------------------------------------------- ");
        Console.WriteLine("|        -------------------------------------------------");
        Console.WriteLine("|              ----------------------------------");
        Console.WriteLine("|                    ---------------------- ");
        Console.WriteLine("|              ----------------------------------");
        Console.WriteLine("|        -------------------------------------------------");
        Console.WriteLine("| --------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("|      Let me see if I have this correct:");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("|");
        Console.WriteLine("|");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("|   --> That's an order for " + HowManyLoaves + " loaves of bread and " + HowManyRolls + " cinnamon rolls <--");
        Console.WriteLine("|");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("|--------------------------------------------------------------------|");
        Bread breadOrder = new Bread(HowManyLoaves);
        Pastry pastryOrder = new Pastry(HowManyRolls);
        int pastryCost = pastryOrder.TotalPastryCost();
        int breadCost = breadOrder.TotalBreadCost();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("|              --> Your total cost today is:  " + "$" + (breadCost + pastryCost)+ " <--                |");

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("|--------------------------------------------------------------------|");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("|        Thanks for coming in today, we hope to see you again soon!  |");
        Console.WriteLine("|--------------------------------------------------------------------|");
        Console.WriteLine();
        Console.WriteLine();
      } 
      else if (yesOrNo == "no" || yesOrNo == "n")
      {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("|    -----------------------------------------------------------------");
        Console.WriteLine("|       -------------------------------------------------------------");
        Console.WriteLine("|        ---------------------------------------------------------");
        Console.WriteLine("|          -----------------------------------------------------");
        Console.WriteLine("|        ---------------------------------------------------------");
        Console.WriteLine("|       ------------------------------------------------------------");
        Console.WriteLine("|    -----------------------------------------------------------------");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("       Not today?  Ok, well thanks for coming in, please visit again soon.");
        Console.WriteLine();
        Console.WriteLine();
      }
    }
  }
}