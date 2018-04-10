using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using ConsumeRestEstates.Integration;

namespace ConsumeRestEstates.Controllers
{
    public class LollandEstateController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var service = new EstateService();
            var estates = await service.SearchAsync();

            ViewBag.Message = "Your application description page.";

            return View(estates);
        }

        public async Task<ActionResult> Detail(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));

            var service = new EstateService();
            var estates = await service.GetAsync(id);

            return View(estates);
        }
    }
}