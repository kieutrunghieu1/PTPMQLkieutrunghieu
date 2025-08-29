using Microsoft.AspNetCore.Mvc;
using NewMVC.Models;

namespace NewMVC.Controllers
{
    public class TuoiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Tuoi());
        }

        [HttpPost]
        public IActionResult Index(Tuoi model)
        {
            if (model.NamSinh > 0)
            {
                int namHienTai = DateTime.Now.Year;
                model.TuoiTinh = namHienTai - model.NamSinh;
            }

            return View(model);
        }
    }
}
