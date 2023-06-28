using System.Security.Cryptography;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2002.Models;
using BaiThucHanh2002.Models.Process;

namespace BaiThucHanh2002.Controllers;

public class HomeController : Controller
{
    StringProcess abc = new StringProcess();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult HelloWorld()
    {
        return View();
    }
    [HttpPost]
    public IActionResult HelloWorld(string FullName, string PhoneNumber)
    {
        string strResult = "Hello " + FullName + "-" + PhoneNumber;
        ViewBag.message = strResult;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}