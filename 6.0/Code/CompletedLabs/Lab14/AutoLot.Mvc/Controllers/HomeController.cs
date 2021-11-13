﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - HomeController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/11/13
// ==================================

namespace AutoLot.Mvc.Controllers;

[Route("[controller]/[action]")]
public class HomeController : Controller
{
    private readonly IAppLogging<HomeController> _logger;

    public HomeController(IAppLogging<HomeController> logger)
    {
        _logger = logger;
    }

    [Route("/")]
    [Route("/[controller]")]
    [Route("/[controller]/[action]")]
    [HttpGet]
    public IActionResult Index([FromServices] IOptionsMonitor<DealerInfo> dealerOptionsMonitor)
    {
        //_logger.LogAppError("Test error");
        return View(dealerOptionsMonitor.CurrentValue);
    }

    [HttpGet]
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [HttpGet]
    public IActionResult GrantConsent()
    {
        HttpContext.Features.Get<ITrackingConsentFeature>().GrantConsent();
        return RedirectToAction(nameof(Index), nameof(HomeController).RemoveController(),
            new {area = ""});
    }
    [HttpGet]
    public IActionResult WithdrawConsent()
    {
        HttpContext.Features.Get<ITrackingConsentFeature>().WithdrawConsent();
        return RedirectToAction(nameof(Index), nameof(HomeController).RemoveController(),
            new {area = ""});
    }
    [HttpGet]
    public IActionResult RazorSyntax([FromServices] ICarRepo carRepo)
    {
        var car = carRepo.Find(1);
        return View(car);
    }

}