using System;
using System.Collections.Generic;
using Domain.Creterias;

namespace Domain.Repository
{
    public interface INuGetPackagesRepository
	{
		IObservable<IList<NuGetPackage>> SearchPackages(ICriteria criteria);
	}
}

