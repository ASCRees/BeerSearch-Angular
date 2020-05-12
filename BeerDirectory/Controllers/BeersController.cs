using System.Collections.Generic;
using BeerDirectory.Core.Repositories.Interfaces.Filters;
using BeerDirectory.Core.Services.Filters;
using BeerDirectory.Core.Services.Interfaces;
using BeerDirectory.Core.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeerDirectory.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BeersController : ControllerBase
	{
		private readonly IBeerService _service;

		public BeersController(IBeerService service)
		{
			_service = service;
		}
		
		[HttpGet]
		public List<BeerModel> Get([FromQuery] BeerModelFilter filter)
		{
			var models = _service.Get(filter);
			return models;
		}
	}
}