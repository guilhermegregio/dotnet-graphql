using aspnetcoregraphql.Data;
using GraphQL.Types;

namespace aspnetcoregraphql.Models
{
    public class PlanetsType : ObjectGraphType<Planets>
    {
        public PlanetsType()
        {
            Field(p => p.count).Description("Total of planets.");
            Field<ListGraphType<PlanetType>>("results", "planet");
        }
    }
}