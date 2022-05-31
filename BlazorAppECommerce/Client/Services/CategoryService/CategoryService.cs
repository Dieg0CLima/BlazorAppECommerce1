using BlazorAppECommerce.Shared;
using System.Collections.Generic;

namespace BlazorAppECommerce.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set ; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category> { 
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Comics", Url = "comics", Icon = "comic" },
                new Category { Id = 3, Name = "Funkos", Url = "funkos", Icon = "funko" }
            };
        }
    }
}
