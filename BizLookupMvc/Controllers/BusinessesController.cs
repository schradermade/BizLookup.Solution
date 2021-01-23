using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BizLookupMvc.Models;

namespace BizLookupMvc.Controllers
{
  public class BusinessesController : Controller
  {
    public IActionResult Index()
    {
      var allBusinesses = Business.GetBusinesses();
      return View(allBusinesses);
    }

    [HttpPost]
    public IActionResult Index(Business business)
    {
      Business.Post(business);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var business = Business.GetDetails(id);
      return View(business);
    }

    public IActionResult Edit(int id)
    {
      var business = Business.GetDetails(id);
      return View(business);
    }

    [HttpPost]
    public IActionResult Details(int id, Business business)
    {
      business.BusinessId = id;
      Business.Put(business);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Business.Delete(id);
      return RedirectToAction("Index");
    }
  }
}