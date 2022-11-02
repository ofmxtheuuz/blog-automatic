using System.Diagnostics;
using BlogOnline.Database;
using Microsoft.AspNetCore.Mvc;
using BlogOnline.Models;
using BlogOnline.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BlogOnline.Controllers;

public class HomeController : Controller
{
    private readonly AplicationDbContext _aplicationDbContext;

    public HomeController(AplicationDbContext aplicationDbContext)
    {
        _aplicationDbContext = aplicationDbContext;
    }

    public ActionResult Index()
    {
        return View();
    }

    public async Task<ActionResult> V()
    {
        return View(await _aplicationDbContext.Artigos.ToListAsync());
    }

    [HttpPost]
    public async Task Read(ArtigoViewModel model)
    {
        await _aplicationDbContext.Artigos.AddAsync(new() { Titulo = model.Titulo, Autor = model.Autor, Content = model.Content, DataEnvio = DateTime.Now});
        await _aplicationDbContext.SaveChangesAsync();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}