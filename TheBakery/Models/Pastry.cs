using System;

namespace TheBakery.Models
{
  public class Pastry
  {
    public int HowManyRolls { get; set; }
    public int CostPerRoll { get; set; }

    public Pastry(int howManyRolls)
    {
      HowManyRolls = howManyRolls;
      CostPerRoll = 2;
    }
    public int TotalPastryCost()
    {
      int rollsTotalCost = 0;
      
      if (HowManyRolls >= 3)
      {
        int discountPastries = Convert.ToInt32(HowManyRolls/3);
        rollsTotalCost = (((HowManyRolls - discountPastries) * 2) + discountPastries);
      }
      else
      {
        rollsTotalCost = HowManyRolls * 2;
      }

      return rollsTotalCost;
    }
  }
}