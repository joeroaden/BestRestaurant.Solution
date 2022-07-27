namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set;}
    public string Name { get; set;}
    public string Description { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}