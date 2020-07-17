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
      } // Start totalCost at 0 

      return rollsTotalCost;  // return totalCost after calculations
    }
  }
}