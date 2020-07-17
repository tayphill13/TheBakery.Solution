
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
      
      if (HowManyRolls % 3 == 0)
      {
        rollsTotalCost = ((HowManyRolls * 3)-((HowManyRolls/3) * CostPerRoll));
      }
      else
      {
        rollsTotalCost = (CostPerRoll * (HowManyRolls - 1)) - ((HowManyRolls/3) * CostPerRoll) + CostPerRoll;
      }

      return rollsTotalCost;  // return totalCost after calculations
    }
  }
}