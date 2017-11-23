using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarouselView.ViewModels;
using CarouselView.Views;
using CarouselView.Models;

namespace CarouselView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BooksPage : ContentPage
	{


		//View _currentView;
		////StackLayout slideDots;
		//double _height, _width;
		//private Image[] dots;
		//CarouselPage CarouselPage;

		//int numPage, currentPage = 0;
		////Timer timer;
		//int dotCount = 1;

		public BooksPage()
		{
			InitializeComponent();
			

			BindingContext = new BooksViewModel();

			////List<Book> images =  ;
			//numPage = 3;
			//dots = new Image[numPage];

			//Image whiteDot = new Image();

			//for (int i = 0; i < numPage; i++)
			//{
			//	dots[i] = new Image();


			//	dots[i].Source = ImageSource.FromResource("CarouselView.Images.Dots.noactive_dot.png");

			//	//LinearLayout.LayoutParams param = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.WrapContent);
			//	//param.SetMargins(8, 0, 8, 0);
			//	//slideDots.AddView(dots[i], param);

			//	slideDots.Children.Add(dots[i]);

			//}

			//dots[0].Source = ImageSource.FromResource("CarouselView.Images.Dots.active_dot.png");

		}

		private async void LoadView()
		{
		//	cell.ScaleTo(0.5, 10);
		//	btnRotate.IsVisible = true;
		//	await btnRotate.ScaleTo(1.2, 250, Easing.CubicIn);
		//	btnRotate.ScaleTo(1, 500, Easing.BounceOut);
		}

			void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
		=> ((ListView)sender).SelectedItem = null;


		void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var selectedItem = e.SelectedItem as Book;

			//BindingContext = new DetailsViewModel(selectedItem);

			var book = ((ListView)sender).SelectedItem as Book;

			
			if (book == null)
				return;

			Navigation.PushAsync(new DetailsPage(book));

		}

		private void CarouselSchools_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

		}

		async void ButtonCarouselPages_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new BooksPage());
		}
	}
}