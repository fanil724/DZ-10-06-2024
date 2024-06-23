using DZ_21_06.Models;
using Microsoft.AspNetCore.Mvc;

namespace DZ_21_06.Controllers
{
    public class HomeController : Controller
    {
        private Department department = new Department();

        public HomeController(IConfiguration con)
        {
            department = con.Get<Department>();           
        }


        public IActionResult Index()
        {
            if (department != null)
            {
                return View(department);
            }
            return View();
        }
    }
}
