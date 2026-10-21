using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HolaMVC.Models;

namespace HolaMVC.Controllers;


public class SaludoController: Controller
{
    [HttpGet]
    public IActionResult index()
    {
        return View(new Persona());
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult index(Persona persona)
    {
        if (!ModelState.IsValid)
        {
            return View(persona);
        }
        return View("Resultado", persona);
    }
}