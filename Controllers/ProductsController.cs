using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using ComputerShop.Models;

namespace ComputerShop.Controllers
{
    public class ProductsController : Controller
    {
        ProductsContext db;
        public ProductsController(ProductsContext context)
        {
            db = context;
        }
        //метод по выводу списка продуктов и таблицы Products
        //Метод принимает параметры name - имя продукта и search - элемент radiobutton 
        public IActionResult Index(string? name, string? search)
        {

            if (!string.IsNullOrEmpty(name) && search == "PartialSearch")
            {
                return View(db.Products.Where(p => EF.Functions.Like(p.Name, $"%{name}%")).ToList());
            }
            else if (!string.IsNullOrEmpty(name) && search == "FullSearch")
            {
                return View(db.Products.Where(p => p.Name == name).ToList());
            }
            return View(db.Products.ToList());
        }
        //поиск по имени

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        //добавление продуктов
        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //post метод на удаление продукта по id
        [HttpPost]
        public IActionResult Delete(Guid? id)
        {
            if (id != null)
            {
                Product? product = db.Products.FirstOrDefault(p => p.Id == id);
                db.Products.Remove(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
        //метод на изменение продукта по айти, с передачей на форму
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            if (id != null)
            {
                Product? product = db.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    return View(product);
                }
            }
            return NotFound();
        }
        //метод изменения продукта на отдельной форме, который принимает объект пробукта из метода Get
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
