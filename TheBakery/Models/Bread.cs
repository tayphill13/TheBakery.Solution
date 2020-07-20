
namespace TheBakery.Models
{
  public class Bread
  {
    public int HowManyLoaves { get; set; }
    public int CostPerLoaf { get; set; }

    public Bread (int howManyLoaves) 
    {
      HowManyLoaves = howManyLoaves;
      CostPerLoaf = 5;
    }
    public int TotalBreadCost()
    {
      int breadTotalCost = 0;

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
        else
        {
          breadTotalCost = (CostPerLoaf * (HowManyLoaves -2)) - ((HowManyLoaves/3) * CostPerLoaf) + (CostPerLoaf * 2);
        }
      }
      return breadTotalCost;
    }
  }
}