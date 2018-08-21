using aspnetcoregraphql.Data;
using GraphQL.Types;

namespace aspnetcoregraphql.Models
{
    public class PlanetType : ObjectGraphType<Planet>
    {
        public PlanetType()
        {
            Field(p => p.name).Description("The name of the planet.");
            Field(p => p.climate).Description("The climate of planet.");
        }
    }
}