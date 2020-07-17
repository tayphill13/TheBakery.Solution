
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
      
      if (HowManyRolls % 2 == 0)
      {
        rollsTotalCost = ((HowManyRolls * 2)-((HowManyRolls/2) * CostPerRoll));
      }
      else if (HowManyRolls % 2 == 1)
      {
        rollsTotalCost = (CostPerRoll * (HowManyRolls - 1)) - ((HowManyRolls/2) * CostPerRoll) + CostPerRoll;
      }

      return rollsTotalCost;  // return totalCost after calculations
    }
  }
}