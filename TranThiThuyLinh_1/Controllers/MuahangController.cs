using Microsoft.AspNetCore.Mvc;
using TranThiThuyLinh_1.Models;

namespace TranThiThuyLinh_1.Controllers
{
    public class MuahangController : Controller
    {
        public static List<Products> products = new List<Products>();
        public IActionResult Sanpham(bool? check = false)
        {
            if ((bool)check)
            {
                products.Clear();
            }
            else
            {
                return View(products.ToList());
            }
            return View();
        }
        [HttpPost]
        public IActionResult Sanpham(string tensanpham, int soluong, int dongia, double giamgia)
        {
            var homeProduct = new Products(tensanpham, soluong, dongia, giamgia);
            products.Add(homeProduct);
            return View(products);
        }

        public IActionResult RemoveProduct(int position)
        {
            products.RemoveAt(position - 1);
            return RedirectToAction("Sanpham", "Muahang");
        }
    }
}

