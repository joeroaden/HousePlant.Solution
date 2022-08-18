// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Http;
// using HousePlant.Models;
// using Microsoft.EntityFrameworkCore;
// using System.Linq;

//   namespace HousePlant.Controllers.v2
//   {
//   [ApiVersion("2.0")]
//   [Route("api/Plants")]
//   [ApiController]
//   public class PlantsController : ControllerBase
//   {
//     private readonly HousePlantContext _db;

//     public PlantsController(HousePlantContext db)
//     {
//       _db = db;
//     }

//     //GET api/plants
//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<Plant>>> Get (string name, string commonName, string description, string type, string sunlight, string water, string humidity, int tempMin, int tempMax, string soil, string propagation)
//     {
//       var query = _db.Plants.AsQueryable();

//       if (name != null)
//       {
//         query = query.Where(entry => entry.Name == name);
//       }
//         if (commonName != null)
//       {
//         query = query.Where(entry => entry.CommonName == commonName);
//       }
//         if (description != null)
//       {
//         query = query.Where(entry => entry.Description == description);
//       }
//         if (type != null)
//       {
//         query = query.Where(entry => entry.Type == type);
//       }
//         if (sunlight != null)
//       {
//         query = query.Where(entry => entry.Sunlight == sunlight);
//       }
//         if (water != null)
//       {
//         query = query.Where(entry => entry.Water == water);
//       }
//         if (humidity != null)
//       {
//         query = query.Where(entry => entry.Humidity == humidity);
//       }
//         if (tempMin > 0)
//       {
//         query = query.Where(entry => entry.TempMin >= tempMin);
//       }
//         if (tempMax > 0)
//       {
//         query = query.Where(entry => entry.TempMax <= tempMax);
//       }
//         if (soil != null)
//       {
//         query = query.Where(entry => entry.Soil == soil);
//       }
//         if (propagation != null)
//       {
//         query = query.Where(entry => entry.Propagation == propagation);
//       }
//       return await query.ToListAsync();
//     }

//     //Get: api/Plants/5
//     [HttpGet("{id}")]
//     public async Task<ActionResult<Plant>> GetPlant(int id)
//     {
//       var plant = await _db.Plants.FindAsync(id);

//       if (plant == null)
//       {
//         return NotFound();
//       }
//       return plant;
//     }

//     //Put: api/Plant/5
//     // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

//     [HttpPut("{id}")]
//     public async Task<IActionResult> Put(int id, Plant plant)
//     {
//       if (id != plant.PlantId)
//       {
//         return BadRequest();
//       }

//       _db.Entry(plant).State = EntityState.Modified;

//       try
//       {
//         await _db.SaveChangesAsync();
//       }
//       catch (DbUpdateConcurrencyException)
//       {
//         if(!PlantExists(id))
//         {
//           return NotFound();
//         }
//         else
//         {
//           throw;
//         }
//       }
//       return NoContent();
//     }

//     //Post: api/Plants
//     [HttpPost]
//     public async Task<IActionResult> Post(Plant plant)
//     {
//       _db.Plants.Add(plant);
//       await _db.SaveChangesAsync();

//       return CreatedAtAction(nameof(GetPlant), new {id = plant.PlantId }, plant);
//     }

//     //Delete: api/Plants/5
//     [HttpDelete("{id}")]
//     public async Task<IActionResult> DeletePlant(int id)
//     {
//       var plant = await _db.Plants.FindAsync(id);
//       if (plant == null)
//       {
//         return NotFound();
//       }

//       _db.Plants.Remove(plant);
//       await _db.SaveChangesAsync();

//       return NoContent();
//     }

//     private bool PlantExists(int id)
//     {
//       return _db.Plants.Any(e => e.PlantId == id);
//     }
//   }
//   }