using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SF.Mod37.XamarinHomeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}
		private void Login_Click(object sender, EventArgs e)
		{

           string xaml = "<Button Text=\"⌛ Attempting login...\"  />";
           loginButton.LoadFromXaml(xaml);

		}
	}
}