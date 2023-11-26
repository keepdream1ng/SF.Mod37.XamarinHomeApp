using SF.Mod37.XamarinHomeApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SF.Mod37.XamarinHomeApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new ClimatePage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
