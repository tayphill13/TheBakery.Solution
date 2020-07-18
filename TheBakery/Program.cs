using System;
using System.Collections.Generic;
using TheBakery.Models;


namespace TheBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("Welcome to Pierre's Bakery! Our baked goods are great and our specials will keep you coming back for more");
      Console.WriteLine("------------------------------------------------------------------------");
      Console.WriteLine("Bread is $5 per loaf and if you buy 2, you can get a 3rd loaf for free!");
      Console.WriteLine("For pastries we have Cinnamon Rolls, they're $2, or you can get 3 for $5  -----  Recommended by kids!");
      Console.WriteLine("------------------------------------------------------------------------");
      Console.WriteLine("Would you like some bread or a pastry?");
      Console.WriteLine(" -----------------------------------------------------------------------");
      Console.WriteLine(" -----------------------------------------------------------------------");
      Console.WriteLine(" -----------------------------------------------------------------------");
      string yesOrNo = Console.ReadLine().ToLower();
      if (yesOrNo == "yes")
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("How many loaves of bread would you like today:  ");
        int HowManyLoaves = int.Parse(Console.ReadLine());
        Console.WriteLine(" ---- ");
        Console.Write("And any cinnamon roll pastries?:  ");
        int HowManyRolls = int.Parse(Console.ReadLine());
        Console.WriteLine(" ------------------------------------------------------------------------- ");
        Console.WriteLine(" -------------------------------------------------- ");
        Console.WriteLine(" -------------------------------- ");
        Console.Write("Let me see if I have this correct:   ");
        Console.WriteLine("That's an order for " + HowManyLoaves + " Loaves of Bread and " + HowManyRolls + " cinnamon rolls");
        // Need UI Logic to calculate cost
        Bread breadOrder = new Bread(HowManyLoaves);
        Pastry pastryOrder = new Pastry(HowManyRolls);
        int pastryCost = pastryOrder.TotalPastryCost();
        int breadCost = breadOrder.TotalBreadCost();

        Console.WriteLine("Your total cost today is:  " + "$" + (breadCost + pastryCost));  //Add totalCost here
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(" -------------------------------------------- ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Thanks for coming in today, we hope to see you again soon!");
      } 
      else if (yesOrNo == "no")
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Not today?  Ok, well thanks for coming in, please visit again soon.");
      }
    }
  }
}