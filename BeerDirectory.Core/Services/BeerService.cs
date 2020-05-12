using BeerDirectory.Core.Domain.Entities;
using BeerDirectory.Core.Repositories.Interfaces;
using BeerDirectory.Core.Repositories.Interfaces.Filters;
using BeerDirectory.Core.Services.Filters;
using BeerDirectory.Core.Services.Interfaces;
using BeerDirectory.Core.Services.Models;

namespace BeerDirectory.Core.Services
{
	public class BeerService : ApplicationModelService<BeerModel, Beer, BeerModelFilter, IBeerFilter>, IBeerService
	{
		private readonly IBeerRepository _repository;
		
		public BeerService(IBeerRepository repository) : base(repository)
		{
			_repository = repository;
		}

		public override BeerModel ConvertEntityToModel(Beer entity)
		{
			return (BeerModel) entity;
		}
	}
}