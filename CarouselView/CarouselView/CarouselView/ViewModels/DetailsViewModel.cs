using System;
using CarouselView.Models;

namespace CarouselView.ViewModels
{
	public class DetailsViewModel
	{
		public Book Book { get; set; }
		public DetailsViewModel(Book Book)
		{
			Book = Book;
		}
	}
}
