namespace HousePlant.Models
{
  public class HousePlant
  {
    public int PlantId { get; set; }
    public string Name { get; set; }
    public string CommonName { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public string Sunlight { get; set; }
    public string Water { get; set; }
    public string Humidity { get; set; }
    public string Soil { get; set; }
    public string Propagation { get; set; }
    public int TempMin { get; set; }
    public int TempMax { get; set; }
  }
}