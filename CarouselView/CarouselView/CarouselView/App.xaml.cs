using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarouselView.Helpers;
using CarouselView.ViewModels;
using CarouselView.Views;
using Xamarin.Forms;

namespace CarouselView
{

	public static class ViewModelLocator
	{
		static BooksViewModel booksVM;
		public static BooksViewModel BooksViewModel
		=> booksVM ?? (booksVM = new BooksViewModel());

		static DetailsViewModel detailsVM;
		public static DetailsViewModel DetailsViewModel
		=> detailsVM ?? (detailsVM = new DetailsViewModel(BookHelper.Books[0]));
	}

	public partial class App : Application
    {
        public App()
        {
			//InitializeComponent();

			//MainPage = new CarouselView.MainPage();

			MainPage = new NavigationPage(new BooksPage())
			{
				BarTextColor = Color.White,
				BarBackgroundColor = Color.FromHex("#2196F3")
			};
		}

		protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
