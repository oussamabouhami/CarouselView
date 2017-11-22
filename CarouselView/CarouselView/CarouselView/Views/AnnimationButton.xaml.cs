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
		public AnnimationButton()
		{
			InitializeComponent();
			
		}

		private async void btnRotate_Clicked(object sender, EventArgs e)
		{
			await btnRotate.FadeTo(0, 2000);
			await btnRotate.FadeTo(1, 1000);
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
			await btnRotate2.FadeTo(0, 500);
			await btnRotate2.ScaleTo(2, 1000);
			await btnRotate2.FadeTo(1, 250);
			await btnRotate2.ScaleTo(1, 250);
		}

		private async void btnRotate3_Clicked(object sender, EventArgs e)
		{
			await btnRotate3.ScaleTo(.6, 500);
			await btnRotate3.ScaleTo(1.2, 1000);
			await btnRotate3.ScaleTo(1, 1000);
		}

		private async void btnRotate4_Clicked(object sender, EventArgs e)
		{
			await btnRotate4.ScaleTo(0.6, 1000);
			await btnRotate4.ScaleTo(1.2, 250);
			await btnRotate4.ScaleTo(1, 500);
		}

	}
}