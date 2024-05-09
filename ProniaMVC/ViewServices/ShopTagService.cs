using ProniaMVC.Business.Service.Abstract;
using ProniaMVC.Core.Models;

namespace ProniaMVC.ViewServices
{
    public class ShopTagService
    {
        private readonly ITagService _tagService;

        public ShopTagService(ITagService tagService)
        {
            _tagService = tagService;
        }
        public List<Tag> GetTags()
        {
            return _tagService.GetAllTag();
        }
    }
}
