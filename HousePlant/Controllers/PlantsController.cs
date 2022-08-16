using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HousePlant.Models;
using System;
using System.Linq;

namespace HousePlant.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PlantsController : ControllerBase
  {
    private readonly HousePlantContext _db;

    public PlantsController(HousePlantContext db)
    {
      _db = db;
    }

    //GET api/plants
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get (string name, string commonName, string description, string type, string sunlight, string sater, string humidity, int tempMin, int tempMax, string soil, string propagation)
    {
      var query = _db.Plants.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
        if (commonName != null)
      {
        query = query.Where(entry => entry.CommonName == commonName);
      }
        if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }
        if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
        if (sunlight != null)
      {
        query = query.Where(entry => entry.Sunlight == sunlight);
      }
        if (water != null)
      {
        query = query.Where(entry => entry.Water == water);
      }
        if (humidity != null)
      {
        query = query.Where(entry => entry.Humidity == humidity);
      }
        if (tempMin != null)
      {
        query = query.Where(entry => entry.TempMin == tempMin);
      }
        if (tempMax != null)
      {
        query = query.Where(entry => entry.TempMax == tempMax);
      }
        if (soil != null)
      {
        query = query.Where(entry => entry.Soil == soil);
      }
        if (propagation != null)
      {
        query = query.Where(entry => entry.Propagation == propagation);
      }
      return await query.ToListAsync();
    }

  }
}