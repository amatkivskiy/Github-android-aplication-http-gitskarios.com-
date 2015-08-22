using System;
using System.Collections.Generic;
using System.Reactive.Concurrency;
using Domain.Creterias;
using Domain.Repository;

namespace Domain.UseCases
{
	public class SearchPackagesUseCase : AbstractUseCase<IList<NuGetPackage>, ICriteria>
	{
		private readonly INuGetPackagesRepository repository;

		public SearchPackagesUseCase (IScheduler observeOn, IScheduler subscribeOn, INuGetPackagesRepository repository) : base (observeOn, subscribeOn)
		{
			this.repository = repository;
		}
	
		protected override IObservable<IList<NuGetPackage>> CreateObservable (ICriteria criteria)
		{
			return this.repository.SearchPackages (criteria);
		}
	}
}