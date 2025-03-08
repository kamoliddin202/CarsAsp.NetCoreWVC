using CarsMVC.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarsMVC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _category;

        public CategoriesController(ICategoryService category)
        {
            _category = category;
        }
        public IActionResult Index()
        {
            var categoreis = _category.GetCategories();
            return View(categoreis);
        }
    }
}
