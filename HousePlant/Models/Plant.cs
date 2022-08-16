using System.ComponentModel.DataAnnotations;

namespace HousePlant.Models
{
  public class Plant
  {
    public int PlantId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [StringLength(50)]
    public string CommonName { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    public string Sunlight { get; set; }
    [Required]
    public string Water { get; set; }
    [Required]
    public string Humidity { get; set; }
    [Required]
    public string Soil { get; set; }
    [Required]
    public string Propagation { get; set; }
    [Required]
    [Range(0,100, ErrorMessage = "Temperature Minimum must be between 0 and 100")]
    public int TempMin { get; set; }
    [Required]
    [Range(0,100, ErrorMessage = "Temperature Maximum must be between 0 and 100")]
    public int TempMax { get; set; }
  }
}