using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet_fluxo_de_caixa.Models;
using dotnet_fluxo_de_caixa.db;

namespace dotnet_fluxo_de_caixa.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, MeuDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    private MeuDbContext _context;

    public IActionResult Index()
    {
        var lista = _context.Caixas.ToList();
        ViewBag.lista = lista;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    // pagina test criada
    public IActionResult Test()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
