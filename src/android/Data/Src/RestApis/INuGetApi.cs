using System;
using System.Collections.Generic;
using Domain;
using Refit;
using System.Net.Http;

namespace Data.RestApis
{
    interface INuGetApi
    {
        [Get("/Packages()?$filter=({query})")]
        IObservable<HttpResponseMessage> GetNuGetPackages(string query);
    }
}