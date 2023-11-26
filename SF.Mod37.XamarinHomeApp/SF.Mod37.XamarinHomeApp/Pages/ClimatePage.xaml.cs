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
	public partial class ClimatePage : ContentPage
	{
		private Rectangle _outsideRect = new Rectangle(20, 10, 100, 70);
		private Rectangle _insideRect = new Rectangle(130, 10, 100, 70);
		public ClimatePage()
		{
			InitializeComponent();
			ScanOutside();
			ScanInside();
		}
		public void ScanOutside()
		{
			absLayout.Children.Add(
				new BoxView { Color = Color.LightBlue },
				_outsideRect
			);

			absLayout.Children.Add(
				new Label
				{
					Text = $"Outside",
					VerticalTextAlignment = TextAlignment.Start,
					HorizontalTextAlignment = TextAlignment.Center,
					FontSize = 13
				},
				_outsideRect
			);

			absLayout.Children.Add(
				new Label
				{
					Text = "- 15 °C",
					VerticalTextAlignment = TextAlignment.Center,
					HorizontalTextAlignment = TextAlignment.Center,
					FontSize = 20
				},
				_outsideRect
			);
		}
		public void ScanInside()
		{
			absLayout.Children.Add(
				new BoxView { Color = Color.LightSalmon },
				_insideRect
			);

			absLayout.Children.Add(
				new Label
				{
					Text = $"Inside",
					VerticalTextAlignment = TextAlignment.Start,
					HorizontalTextAlignment = TextAlignment.Center,
					FontSize = 13
				},
				_insideRect
			);

			absLayout.Children.Add(
				new Label
				{
					Text = "+ 24 °C",
					VerticalTextAlignment = TextAlignment.Center,
					HorizontalTextAlignment = TextAlignment.Center,
					FontSize = 20
				},
				_insideRect
			);
		}

	}
}