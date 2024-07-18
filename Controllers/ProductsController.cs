using ComputerShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComputerShop.Controllers
{
    /// <summary>
    /// Контроллер продукта с CRUD-операциями
    /// </summary>
    public class ProductsController : Controller
    {
        readonly ProductsContext db;

        public ProductsController(ProductsContext context)
        {
            db = context;
        }

        /// <summary>
        /// Отображение списка продуктов
        /// с возможностью поиска по наименованию продукта
        /// </summary>
        /// <param name="name">Имя продукта</param>
        /// <param name="search">элемент поиска данных</param>
        /// <returns>Список продуктов</returns> 
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

        /// <summary>
        /// Отображение формы для добавления новой записи
        /// </summary>
        /// <returns>Форма для заполнения данных</returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        /// <summary>
        /// Добавление нового продукта
        /// </summary>
        /// <param name="product">Данные о продукте</param>
        /// <returns>Переход на главную страницу</returns>
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product == null)
            {
                return NotFound();
            }

            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Удаление данных о продукте
        /// </summary>
        /// <param name="Id">Идентификатор записи</param>
        /// <returns>Переход на главную страницу или сообщение об ошибке</returns>
        [HttpPost]
        public IActionResult Delete(Guid? Id)
        {
            if (Id != Guid.Empty)
            {
                Product? product = db.Products.FirstOrDefault(p => p.Id == Id);
                if (product == null)
                {
                    return NotFound();
                }

                db.Products.Remove(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }
        
        /// <summary>
        /// Переход на страницу для изменения записи
        /// </summary>
        /// <param name="Id">Идентификатор записи</param>
        /// <returns>Форма/страница для изменения данных</returns>
        [HttpGet]
        public IActionResult Edit(Guid? Id)
        {
            if (Id != Guid.Empty)
            {
                Product? product = db.Products.FirstOrDefault(p => p.Id == Id);
                if (product != null)
                {
                    return View(product);
                }
            }
            return NotFound();
        }

        /// <summary>
        /// Изменение данных продукта
        /// </summary>
        /// <param name="product">Измененные данные о продукте</param>
        /// <returns>Переход на главную страницу</returns>
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
