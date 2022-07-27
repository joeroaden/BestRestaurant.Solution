namespace BestRestaurant.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string Description { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}