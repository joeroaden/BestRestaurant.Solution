using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public Restaurant()
    {
      this.JoinEntities = new HashSet<CuisineRestaurant>();
    }

    public int RestaurantId { get; set;}
    public string Name { get; set;}
    public string Description { get; set; }
    // public virtual ICollection<Review> Reviews { get; set; }
    public virtual ICollection<CuisineRestaurant> JoinEntities { get;}
  }
}