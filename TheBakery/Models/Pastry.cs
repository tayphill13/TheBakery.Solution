using TheBakery;
using System;

namespace TheBakery.Models
{
  public class Pastry
  {
    public int HowManyRolls { get; set; }
    public int CostPerRoll { get; set; }

    public Pastry(int howManyRolls)    // Pastry Constructor
    {
      HowManyRolls = howManyRolls;    // The two pastry properties
      CostPerRoll = 2;
    }
    public int TotalPastryCost()
    {
      int rollsTotalCost = 0;
      
      if (HowManyRolls >= 3)
      {
        int discountPastries = Convert.ToInt32(HowManyRolls/3);
        Console.WriteLine(discountPastries);
        rollsTotalCost = ((HowManyRolls - discountPastries) * 2) + discountPastries;
        // int discountPastries = Convert.ToInt32(HowManyRolls/3);
        // rollsTotalCost = ((HowManyRolls * 3)-(discountPastries) * CostPerRoll);
      }
      else
        rollsTotalCost = HowManyRolls * 2;
      {
      }

      return rollsTotalCost;  // return totalCost after calculations
    }
  }
}