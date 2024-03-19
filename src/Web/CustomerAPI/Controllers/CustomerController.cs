using Microsoft.AspNetCore.Mvc;
using OrderTrack.Domain.Entities;
using OrderTrack.Persistence.Context;

namespace CustomerAPI.Controllers
{
    public class CustomerController : Controller
    {

        private readonly CustomerDbContext _customerDbContext;

        public CustomerController(CustomerDbContext customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
