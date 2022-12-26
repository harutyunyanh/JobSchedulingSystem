using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class JobDataController : ControllerBase
	{
        private readonly IJobService coffeeShopService;

		public JobDataController(IJobService coffeeShopService)
		{
			this.coffeeShopService = coffeeShopService;
		}

		[HttpGet]
		public async Task<IActionResult> List()
		{
			var coffeeShops = await coffeeShopService.List();
			return Ok(coffeeShops);
		}
	}
}
