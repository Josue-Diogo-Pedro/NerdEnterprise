using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.MVC.Models;

namespace NSE.WebApp.MVC.Controllers;

public class IdentidadeController : Controller
{
    [HttpGet("nova-conta")]
    public IActionResult Registro()
    {
        return View();
    }

    [HttpPost("nova-conta")]
    public async Task<IActionResult> Registro(UsuarioRegistro usuarioRegistro) 
    {

    }

    public IActionResult Login() 
    {
        return View();
    }

}
