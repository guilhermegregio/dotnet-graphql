using System.Linq;
using aspnetcoregraphql.Data;
using GraphQL.Types;

namespace aspnetcoregraphql.Models
{
    public class CategoryType : ObjectGraphType<Planet>
    {
        public CategoryType(IProductRepository productRepository)
        {
            Field(x => x.name).Description("Planets results.");
        }
    }
}