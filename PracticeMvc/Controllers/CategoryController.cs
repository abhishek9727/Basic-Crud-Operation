using Microsoft.AspNetCore.Mvc;
using Service_layer;
using ViewModel;

namespace WebUi.Controllers
{
    public class CategoryController : Controller
    {
       private readonly ICategoryServieces _catserv;

        public CategoryController(ICategoryServieces catserv)
        {
            _catserv = catserv;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel categoryModel)
        {
            if (categoryModel == null)
            {
                return View();
            }
            _catserv.Create(categoryModel);
            return RedirectToAction("Index", "Category");
        }

    }
   
}
