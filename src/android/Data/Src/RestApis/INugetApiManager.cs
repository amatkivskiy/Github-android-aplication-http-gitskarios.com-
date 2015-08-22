using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace NuGetBrowserCommons
{
	public interface INugetApiManager
	{
        IObservable<IList<NuGetPackage>> GetNuGetPackages(string query);
    }
}

