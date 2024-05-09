using Microsoft.AspNetCore.Mvc;
using ProniaMVC.Business.Service.Abstract;
using ProniaMVC.Core.RepsitoryAbstract;

namespace ProniaTemplate.Controllers
{
    public class ShopController : Controller
    {
      private readonly ITagService _tagService;

        public ShopController(ITagService tagService)
        {
            _tagService = tagService;
        }
        public IActionResult Index()
        {
            var tag= _tagService.GetAllTag();
            return View(tag);
        }
    }
}
