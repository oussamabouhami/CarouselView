using System;
using System.Collections.Generic;
using CarouselView.Views;
using Xamarin.Forms;

namespace CarouselView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

		private async void btnAnimations_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AnnimationButton());
		}

		private async void btnCarouselPage_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Buttonn());
		}

		private async void btnCarouselView_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new BooksPage());
		}

		private async void btnCarouselList_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new BooksPage());
		}
		
	}
}
