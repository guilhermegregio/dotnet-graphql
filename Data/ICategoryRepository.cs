using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;
using System.Net.Http;

namespace aspnetcoregraphql.Data
{
    public interface ICategoryRepository
    {
        Task<List<Category>> CategoriesAsync();
        Task<Planets> GetHttp();
        Task<Category> GetCategoryAsync(int id);
    }
}