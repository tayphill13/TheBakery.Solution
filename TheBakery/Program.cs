using System;
using System.Collections.Generic;
using TheBakery.Models;


namespace TheBakery
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Our baked goods are great and our specials will keep you coming back for more");
      Console.WriteLine("------------------------------------------------------------------------");
      Console.WriteLine("Bread is $5 per loaf and if you buy 2, you can get a 3rd loaf for free!");
      Console.WriteLine("Pastries are $2 and you can get 3 for $5  -----  Recommended by kids!");
      Console.WriteLine("------------------------------------------------------------------------");
      Console.WriteLine("Would you like some bread or a pastry?");
      string yesOrNo = Console.ReadLine();
      if (yesOrNo == "yes")
      {
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
        Console.WriteLine("Your total cost today is:  ");  //Add totalCost here
      } 
      else if (yesOrNo == "no")
      {
        Console.WriteLine("Not today?  Ok, well thanks for coming in, please visit again soon.");
      }
    }
  }
}