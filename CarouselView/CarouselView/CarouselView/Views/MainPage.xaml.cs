using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
		async void ButtonTraditionalClicked(object sender, System.EventArgs e)
		{
			//await Navigation.PushAsync(new MonkeysPage());
		}

		async void ButtonDataPagesClicked(object sender, System.EventArgs e)
		{
			await DisplayAlert("Coming soon", "Waiting on those new NuGets!", "OK");
		}
	}
}
