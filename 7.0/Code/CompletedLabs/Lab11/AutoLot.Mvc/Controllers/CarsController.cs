﻿// Copyright Information
// ==================================
// AutoLot70 - AutoLot.Mvc - CarsController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2022/11/10
// ==================================

namespace AutoLot.Mvc.Controllers;

[Route("[controller]/[action]")]
public class CarsController : Controller
{
    [Route("/[controller]")]
    [Route("/[controller]/[action]")]
    [HttpGet]
    public IActionResult Index() => View(); 

    [HttpGet("{makeId}/{makeName}")]
    public IActionResult ByMake(int makeId, string makeName)
    {
        return View();
    }

    [HttpGet("{id?}")]
    public IActionResult Details(int? id)
    {
        return View();
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        return View();
    }
    [HttpGet]
    public IActionResult Delete(int? id)
    {
        return View();
    }

}