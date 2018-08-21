using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcoregraphql.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace aspnetcoregraphql.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private static readonly HttpClient client = new HttpClient();
        private List<Category> _categories;

        public CategoryRepository()
        {
            _categories = new List<Category>{
                new Category()
                {
                    Id = 1,
                    Name = "Computers"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Mobile Phones"
                }
            };
        }

        public Task<List<Category>> CategoriesAsync()
        {
            return Task.FromResult(_categories);
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            return Task.FromResult(_categories.FirstOrDefault(x => x.Id == id));
        }

        public async Task<Planets> GetHttp()
        {
            var response = await client.GetAsync("https://swapi.co/api/planets");
            var responseMessage = await response.Content.ReadAsStringAsync();
            Planets planets = JsonConvert.DeserializeObject<Planets>(responseMessage);

            return planets; 
        }
    }
}