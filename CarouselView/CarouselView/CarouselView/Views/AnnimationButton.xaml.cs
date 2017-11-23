using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnnimationButton : ContentPage
	{
		public  AnnimationButton()
		{
			//LoadView();
			InitializeComponent();
			LoadView();
		}

		private async void LoadView()
		{
			btnRotate.ScaleTo(0.5, 10);
			btnRotate.IsVisible = true;
			await btnRotate.ScaleTo(1.2, 250, Easing.CubicIn);
			btnRotate.ScaleTo(1, 500, Easing.BounceOut);

			btnRotate1.ScaleTo(0.5, 10);
			btnRotate1.IsVisible = true;
			await btnRotate1.ScaleTo(1.2, 250, Easing.CubicIn);
			btnRotate1.ScaleTo(1, 500, Easing.BounceOut);

			btnRotate2.ScaleTo(0.5, 10);
			btnRotate2.IsVisible = true;
			await btnRotate2.ScaleTo(1.2, 250, Easing.CubicIn);
			 btnRotate2.ScaleTo(1, 500, Easing.BounceOut);


			btnRotate3.ScaleTo(0.5, 10);
			btnRotate3.IsVisible = true;
			await btnRotate3.ScaleTo(1.2, 250, Easing.CubicIn);
			btnRotate3.ScaleTo(1, 500 , Easing.BounceOut);

			btnRotate4.ScaleTo(0.5, 10);
			btnRotate4.IsVisible = true;
			await btnRotate4.ScaleTo(1.2, 250, Easing.CubicIn);
			btnRotate4.ScaleTo(1, 500, Easing.BounceOut);
		}

		private async void btnRotate_Clicked(object sender, EventArgs e)
		{
			//await btnRotate.FadeTo(0, 2000);
			//await btnRotate.FadeTo(1, 1000);

			btnRotate.AnchorX = 0;
			btnRotate.AnchorY = 1;
			await btnRotate.RotateTo(90, 3000, new Easing(t => Math.Sin(Math.PI * t) * Math.Cos(10 * Math.PI * t) * Math.Exp(-5 * t)));
		}

		private async void btnRotate1_Clicked(object sender, EventArgs e)
		{
			await btnRotate1.RotateTo(10, 150, Easing.SinOut);
			await btnRotate1.RotateTo(-10, 250, Easing.SinInOut);
			await btnRotate1.RotateTo(0, 150, Easing.SinIn);
		}

		private async void btnRotate2_Clicked(object sender, EventArgs e)
		{
			btnRotate2.Rotation = 0;
			await btnRotate2.RotateTo(360, 500);
			btnRotate2.FadeTo(0, 1000);
			await btnRotate2.ScaleTo(2, 1000);
			btnRotate2.FadeTo(1, 250);
			await btnRotate2.ScaleTo(1, 250);
		}

		private async void btnRotate3_Clicked(object sender, EventArgs e)
		{
			await btnRotate4.ScaleTo(0.6, 1000);
			await btnRotate4.ScaleTo(1.2, 250);
			await btnRotate4.ScaleTo(1, 500);
		}

		private async void btnRotate4_Clicked(object sender, EventArgs e)
		{
			await btnRotate.RotateTo(15, 1000, new Easing(t => Math.Sin(Math.PI * t) * Math.Sin(Math.PI * 20 * t)));
		}

	}
}