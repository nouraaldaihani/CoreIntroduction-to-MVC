using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomerController1 : Controller
    {
        public IActionResult Index()
        {

            List<Customer> customers = new List<Customer>()
            {
                  new Customer { Id = 1, Name = "Noura", Phone = 3333 }
                  };


                return View(customers);
            }
        }
    }

