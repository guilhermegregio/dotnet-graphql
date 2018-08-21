using System.Collections.Generic;

namespace aspnetcoregraphql.Models
{
  public class Planets
  {
    public int count { get; set; }
    public List<Planet> results { get; set; }
  }
}