using ProniaMVC.Business.Service.Abstract;
using ProniaMVC.Core.Models;

namespace ProniaMVC.ViewServices
{
    public class ShopService
    {
        private readonly ICategoryService _categoryService;
       

        public ShopService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        

        public List<Category> GetCategories()
        {
            return _categoryService.GetAllCategory();
        }
        

    }
}
