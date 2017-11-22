using CarouselView.Helpers;
using CarouselView.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace CarouselView.ViewModels
{
	public class School
	{
		public string ImageUrl { get; set; }
		public string Name { get; set; }
	}

	public class BooksViewModel
		{
			public ObservableCollection<Book> Books { get; set; }
			public ObservableCollection<Grouping<string, Book>> BooksGrouped { get; set; }

			public ObservableCollection<School> Schools { get; set; }

			public BooksViewModel()
			{
				Books = BookHelper.Books;
				BooksGrouped = BookHelper.BooksGrouped;
				Schools = new ObservableCollection<School>
				{
					new School
					{
						ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/23c1dd13-333a-459e-9e23-c3784e7cb434/2016-06-02_1049.png",
						Name = "Woodland Park School"
					},
					 new School
					{
						ImageUrl =    "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/6b60d27e-c1ec-4fe6-bebe-7386d545bb62/2016-06-02_1051.png",
						Name = "Cleveland School"
					 },
					new School
					{
						ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/e8179889-8189-4acb-bac5-812611199a03/2016-06-02_1053.png",
						Name = "Phoenix School"
					}
				};
			}
				public int BookCount => Books.Count;
		}
}
