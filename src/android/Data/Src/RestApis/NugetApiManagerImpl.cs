using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.RestApis;
using Domain;
using Newtonsoft.Json.Linq;
using Refit;

namespace NuGetBrowserCommons
{
	public class NugetApiManagerImpl : INugetApiManager
	{
		const string DefaultNuGetServerUrl = "http://www.nuget.org";
//
//		public NugetApiManagerImpl ()
//		{
//		}



//		public async void GetStatistics()
//		{
//			var nugetApi = RestService.For<INuGetApi>(DefaultNuGetServerUrl);
//			var content = await nugetApi.GetStatistics ();
//
//			var results = JObject.Parse(content);
//
//			return new NuGetStatistics 
//			{
//				TotalPackageDownloads = (string)o["page"]Downloads,
//				UniquePackages = results.UniquePackages,
//				TotalPackages = results.TotalPackages
//			};
//		}
	    public IObservable<IList<NuGetPackage>> GetNuGetPackages(string query)
	    {
	        var settings = new RefitSettings();
            var nugetApi = RestService.For<INuGetApi>(DefaultNuGetServerUrl, settings);
	        return null;
	        //			var content = await nugetApi.GetStatistics ();
	    }
    }
}

