
namespace TheBakery.Models
{
  public class Bread
  {
    public int HowManyLoaves { get; set; } // In order to specify number of loaves ordered by user
    public int CostPerLoaf { get; set; }
    
    public Bread (int howManyLoaves)   // Bread Constructor
    {
      HowManyLoaves = howManyLoaves; // The two bread properties, how many and how much for each
      CostPerLoaf = 5;
    }
    // public int TotalBreadCost()
    // {
    //   int breadTotalCost = 0;

    //   // if ()   // I will want to account for the specials here and then add to the breadTotalCost and return breadTotalCost at the bottom
    // }

  }
}