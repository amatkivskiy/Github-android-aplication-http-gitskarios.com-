using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using NuGetBrowserCommons;

namespace NuGetBrowserAndroidApp
{
	[Activity (Label = "NuGetBrowserAndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += async delegate {
//				var nugetApi = new NugetApiManagerImpl();
//				var result = await nugetApi.GetStatistics ();
//
//				var text = string.Format ("NuGetStatistics: UniquePackages => {0}, TotalPackages => {1}, TotalPackageDownloads => {2}", result.UniquePackages, result.TotalPackages, result.TotalPackageDownloads);

//				Toast.MakeText (this, text, ToastLength.Long).Show ();
			};
		}
	}
}


