using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BizLookupApi.Models;

namespace BizLookupApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private BizLookupApiContext _db;

    public BusinessesController(BizLookupApiContext db)
    {
      _db = db;
    }

    // this route is used to search for objects (Businesses) by properties (strings)
    //GET api/Businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get(string name, string industry, string address, string hours)
    {
        var query = _db.Businesses.AsQueryable();

        if (name != null)
        {
        query = query.Where(entry => entry.Name == name);
        }

        if (industry != null)
        {
        query = query.Where(entry => entry.Industry == industry);
        }

        if (address != null)
        {
        query = query.Where(entry => entry.Address == address);
        }

        if (hours != null)
        {
        query = query.Where(entry => entry.Hours == hours);
        }

        return query.ToList();
    }

    // POST api/Businesses
    [HttpPost]
    public void Post([FromBody] Business Business)
    {
      _db.Businesses.Add(Business);
      _db.SaveChanges();
    }
    //GET api/Businesses/5
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id)
    {
        return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business)
    {
        business.BusinessId = id;
        _db.Entry(business).State = EntityState.Modified;
        _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var BusinessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      _db.Businesses.Remove(BusinessToDelete);
      _db.SaveChanges();
    }
        
  }
}