using Microsoft.AspNetCore.Mvc;

namespace NSE.WebApp.MVC.Controllers;

public class IdentidadeController : Controller
{
    [HttpGet("nova-conta")]
    public IActionResult Registro() 
    {
        return View();
    }


}
