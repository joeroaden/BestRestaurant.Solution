using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BestRestaurant.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly BestRestaurantContext _db;

    public CuisinesController(BestRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      ViewBag.PageTitle = "View All Cuisines";
      return View(model);
    }

    public ActionResult Create()
    {
      // ViewBag.RestaurantId = new SelectList(_db.Restaurants, "RestaurantId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}