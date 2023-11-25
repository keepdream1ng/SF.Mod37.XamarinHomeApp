using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SF.Mod37.XamarinHomeApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public const string BUTTON_TEXT = "Login";
		public static int loginCouner = 0;

		public LoginPage()
		{
			InitializeComponent();
			loginButton.Clicked += OnLoginButtonClicked;
			toRegisterButton.Clicked += OnToRegisterPageButtonClicked;
		}

		private void OnLoginButtonClicked(object sender, EventArgs e)
		{
			if (loginCouner == 0)
			{
				loginButton.Text = "Attempting to Log in";
			}
			else if (loginCouner > 5)
			{
				loginButton.IsEnabled = false;
				errorMessage.Text = "Too many attempts to log in, please try later.";
			}
			else
			{
				loginButton.Text = $"Attempting to Log in, current attemt:{loginCouner}";
			}

			loginCouner++;
		}

		private async void OnToRegisterPageButtonClicked(object sender, EventArgs e)
		{
            await Navigation.PushAsync(new RegisterPage());
		}
	}
}