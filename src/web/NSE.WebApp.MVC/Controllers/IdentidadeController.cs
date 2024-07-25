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
        if(!ModelState.IsValid) return View(usuarioRegistro);

        // API - Registro

        if(false) return View(usuarioRegistro);

        // Realizar login na App

        return RedirectToAction("Index", "Home");
    }

    public IActionResult Login() 
    {
        return View();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UsuarioLogin usuarioLogin) 
    {

    }

    [HttpGet("sair")]
    public async Task<IActionResult> Logout() 
    {

    }

}
