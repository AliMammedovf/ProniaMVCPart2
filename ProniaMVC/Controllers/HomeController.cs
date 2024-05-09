using Microsoft.AspNetCore.Mvc;
using ProniaMVC.Business.Service.Abstract;
using System.Diagnostics;

namespace ProniaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureService _featureService;


        public HomeController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IActionResult Index()
        {
            var feature=_featureService.GetAllFeatures();   
            return View(feature);
        }

       
    }
}
