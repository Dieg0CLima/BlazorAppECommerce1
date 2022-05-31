using BlazorAppECommerce.Shared;

namespace BlazorAppECommerce.Client.Services.CategoryService
{
    public interface ICategoryService
    {

        List<Category> Categories { get; set; }

        void LoadCategories();
    }
}
