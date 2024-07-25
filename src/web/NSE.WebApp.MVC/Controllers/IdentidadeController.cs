using Microsoft.AspNetCore.Mvc;
using NSE.WebApp.MVC.Models;

namespace NSE.WebApp.MVC.Controllers;

public class IdentidadeController : Controller
{
    [HttpGet("nova-conta")]
    public IActionResult Registro() => View();

    [HttpPost("nova-conta")]
    public async Task<IActionResult> Registro(UsuarioRegistro usuarioRegistro) 
    {
        if(!ModelState.IsValid) return View(usuarioRegistro);

        // API - Registro

        if(false) return View(usuarioRegistro);

        // Realizar login na App

        return RedirectToAction("Index", "Home");
    }

    [HttpGet("login")]
    public IActionResult Login() => View();

    [HttpPost("login")]
    public async Task<IActionResult> Login(UsuarioLogin usuarioLogin) 
    {
        if (!ModelState.IsValid) return View(usuarioLogin);

        // API - Login

        if (false) return View(usuarioLogin);

        // Realizar login na App

        return View("Index", "Home");

    }

    [HttpGet("sair")]
    public async Task<IActionResult> Logout() 
    {
        return RedirectToAction("Index", "Home");
    }

}
