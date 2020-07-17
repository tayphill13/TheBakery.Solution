using TheBakery.Models;
using System;
using System.Collections.Generic;


namespace TheBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Our baked goods are great and our specials will keep you coming back for more");
      Console.WriteLine("------------------------------------------------------------------------");
      Console.WriteLine("Bread is $5 per loaf and if you buy 2, you can get a 3rd loaf for free!");
      Console.WriteLine("------------------------------------------------------------------------");
      Console.WriteLine("How many loaves of bread would you like today?");
      int howManyLoaves = Console.ReadLine();
  }
}