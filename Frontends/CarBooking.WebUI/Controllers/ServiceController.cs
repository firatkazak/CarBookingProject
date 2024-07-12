﻿using Microsoft.AspNetCore.Mvc;

namespace CarBooking.WebUI.Controllers;
public class ServiceController : Controller
{
    public IActionResult Index()
    {
        ViewBag.v1 = "Hizmetler";
        ViewBag.v2 = "Hizmetlerimiz";
        return View();
    }
}