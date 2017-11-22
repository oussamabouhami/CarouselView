using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarouselView.ViewModels;
using CarouselView.Models;

namespace CarouselView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BooksPage : ContentPage
	{
		public BooksPage()
		{
			InitializeComponent();

			BindingContext = new BooksViewModel();
		}
		void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
		=> ((ListView)sender).SelectedItem = null;

		void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var book = ((ListView)sender).SelectedItem as Book;
			if (book == null)
				return;
		}
	}
}