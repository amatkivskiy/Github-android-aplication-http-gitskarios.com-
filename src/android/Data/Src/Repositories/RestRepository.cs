namespace Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Reactive.Linq;
    using Domain;
    using Domain.Creterias;
    using Domain.Repository;

    public class RestRepository : INuGetPackagesRepository
	{
		public IObservable<IList<NuGetPackage>> SearchPackages (ICriteria criteria)
		{
			return Observable.Empty<IList<NuGetPackage>> ();
		}
	}
}

