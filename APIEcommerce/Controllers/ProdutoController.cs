using Microsoft.AspNetCore.Mvc;

namespace APIEcommerce.Controllers;

public class ProdutoController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}