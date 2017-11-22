using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CarouselView.Views
{
	public class Buttonn : ContentPage
	{
		public Buttonn()
		{
			Button btnRotate = new Button
			{
				Text = "Click Me",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};

			btnRotate.Clicked+= async (sender, arge) =>
			{
				await btnRotate.RotateTo(15, 1000, new Easing(t => Math.Sin(Math.PI * t) * Math.Sin(Math.PI * 20 * t)));
			};

			this.Content = btnRotate;
		}
	}
}