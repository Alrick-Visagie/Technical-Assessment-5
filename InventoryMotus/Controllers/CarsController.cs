using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventoryMotus.Controllers
{

    public class CarsController : Controller
    {
        //private object db;

        public ActionResult Index()
        {
            return View();//db.Cars.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCar(Models.Cars car)
        {
            //db.Cars.Add(car);
            //db.SaveChanges();
            return RedirectToAction("Index", "Cars");
        }
        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                Models.Cars  car = db.Cars.Where(s => s.Id == id).First();
                db.Cars.Remove(car);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }

        }
        public ActionResult Update(int id)
        {
            return View();// db.Cars.Where(s => s.Id == id).First());
        }
        [HttpPost]
        public ActionResult UpdateCar(Models.Cars car)
        {
            Models.Cars ca = db.Cars.Where(s => s.Id == Cars.id).First();
            ca.model = cars.model;
            ca.make = cars.make;
            ca.colour = cars.colour;
            db.SaveChanges();
            return RedirectToAction("Index", "Cars");


        }

    }
}
