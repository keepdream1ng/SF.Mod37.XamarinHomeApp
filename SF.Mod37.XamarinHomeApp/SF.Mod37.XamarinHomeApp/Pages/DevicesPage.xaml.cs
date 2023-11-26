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
	public partial class DevicesPage : ContentPage
	{
		public DevicesPage()
		{
			InitializeComponent();
			GetDevices();
		}

		public void GetDevices()
		{
			// No API call here yet.
			var homeDevices = new List<string>()
		   {
				"Smart TV",
				"Smart Refrigerator",
				"Smart Thermostat",
				"Smart Light Bulbs",
				"Smart Doorbell",
				"Smart Lock",
				"Smart Speaker",
				"Smart Coffee Maker",
				"Smart Vacuum Cleaner",
				"Smart Air Purifier",
				"Smart Security Camera",
				"Smart Washing Machine",
				"Smart Microwave",
				"Smart Blender",
				"Smart Garage Door Opener"
		   };

			var innerStack = new StackLayout();
			foreach (string deviceName in homeDevices)
			{
				var deviceLabel = new Label() { Text = $"   {deviceName}", FontSize = 17 };
				innerStack.Children.Add(new Label());
				innerStack.Children.Add(deviceLabel);
			}

			scrollView.Content = innerStack;
		}
	}
}