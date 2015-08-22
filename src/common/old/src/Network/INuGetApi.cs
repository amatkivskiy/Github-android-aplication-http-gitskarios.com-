using System;
using System.Threading.Tasks;
using Refit;

namespace NuGetBrowserCommons
{
	public interface INuGetApi
	{
		[Get("/stats/totals")]
		Task<string> GetStatistics();
	}
}