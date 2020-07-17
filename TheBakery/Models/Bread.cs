using System;

namespace TheBakery.Models
{
  public class Bread
  {
    public int HowManyLoaves { get; set; }
    public int CostPerLoaf { get; set; }

    public Bread (int howManyLoaves)    // Bread Constructor
    {
      HowManyLoaves = howManyLoaves;    // The two bread properties
      CostPerLoaf = 5;
    }
    public int TotalBreadCost()
    {
      int breadTotalCost = 0; // Start totalCost at 0 

      if (HowManyLoaves % 3 == 0)
      {
        breadTotalCost = ((HowManyLoaves * 5) - ((HowManyLoaves/3) * CostPerLoaf));
      }
      else if (HowManyLoaves < 3)
      {
        breadTotalCost = HowManyLoaves * CostPerLoaf;
      }
      else
      {
        if (HowManyLoaves % 3 == 1)
        {
          breadTotalCost = (CostPerLoaf * (HowManyLoaves - 1)) - ((HowManyLoaves/3) * CostPerLoaf) + CostPerLoaf;
        }
      }
      return breadTotalCost;  // return totalCost after calculations
    }
  }
}