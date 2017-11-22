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
				btnRotate.AnchorX = 0;
				btnRotate.AnchorY = 1;
				await btnRotate.RotateTo(90, 3000, new Easing(t => 1 - Math.Cos(10 * Math.PI * t) * Math.Exp(-5 * t)));
				await btnRotate.TranslateTo(0, (Height - btnRotate.Height) / 2 - btnRotate.Width , 1000, Easing.BounceOut);
				btnRotate.AnchorX = 1;
				btnRotate.AnchorY = 0;

				btnRotate.TranslationX -= btnRotate.Width - btnRotate.Height;
				btnRotate.TranslationY += btnRotate.Width + btnRotate.Height;

				btnRotate.RotateYTo(360, 1000);
				await btnRotate.RotateTo(180, 1000, Easing.SpringIn);

				btnRotate.FadeTo(0, 4000);
				await btnRotate.TranslateTo(0, -Height, 5000 , Easing.CubicIn);
			};

			this.Content = btnRotate;
		}
	}
}