using Microsoft.AspNetCore.Mvc;
using StrategyDesignPattern.Web.Models;
using StrategyDesignPattern.Web.StrategyPattern;

namespace StrategyDesignPattern.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IEnumerable<IShippingStrategy> _strategies;

        public OrderController(IEnumerable<IShippingStrategy> strategies)
        {
            _strategies = strategies;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrderViewModel model)
        {
            var SelectedStrategy = _strategies.FirstOrDefault(x => x.CompanyName == model.SelectCargo);

            model.CalculatedShippingCost = SelectedStrategy.CalculateCost(model.OrderTotal);

            return View(model);
        }
    }
}