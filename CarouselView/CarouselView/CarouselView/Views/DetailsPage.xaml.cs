﻿using CarouselView.Models;
using CarouselView.ViewModels;
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
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage(Book book)
		{
			InitializeComponent();

			//BindingContext = new DetailsViewModel(book);
		}
	}
}