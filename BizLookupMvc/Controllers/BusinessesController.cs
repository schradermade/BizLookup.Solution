using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BizLookupMvc.Models;
using System.Threading.Tasks;

namespace BizLookupMvc.Controllers
{
  public class BusinessesController : Controller
  {
    public IActionResult Index()
    {
      var allBusinesses = Business.GetBusinesses();
      return View(allBusinesses);
    }

    public async Task<IActionResult> Details(int id)
    {
      Business business = await Business.GetDetails(id);
      return View(business);
    }

    public async Task<IActionResult> Edit(int id)
    {
      var business = await Business.GetDetails(id);
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

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    [HttpPost]
    public async Task<IActionResult> Index(Business business)
    {
      await Business.PostBiz(business);
      return RedirectToAction("Index");
    }
  }
}