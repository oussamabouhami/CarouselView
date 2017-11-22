using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CarouselView.Models;
using System.Linq;


namespace CarouselView.Helpers
{
	public static class BookHelper
	{
		private static Random random;

		public static Book GetRandomBook()
		{
			//var output = Newtonsoft.Json.JsonConvert.SerializeObject(Books);
			return Books[random.Next(0, Books.Count)];
		}


		public static ObservableCollection<Grouping<string, Book>> BooksGrouped { get; set; }

		public static ObservableCollection<Book> Books { get; set; }

		static BookHelper()
		{
			random = new Random();
			Books = new ObservableCollection<Book>();
			Books.Add(new Book
			{
				Name = "Baboon",
				Location = "Africa & Asia",
				Details = "Baboons are African and Arabian Old World Books belonging to the genus Papio, part of the subfamily Cercopithecinae.",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
			});

			Books.Add(new Book
			{
				Name = "Capuchin Book",
				Location = "Central & South America",
				Details = "The capuchin Books are New World Books of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
			});

			Books.Add(new Book
			{
				Name = "Blue Book",
				Location = "Central and East Africa",
				Details = "The blue Book or diademed Book is a species of Old World Book native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueBook.jpg/220px-BlueBook.jpg"
			});


			Books.Add(new Book
			{
				Name = "Squirrel Book",
				Location = "Central & South America",
				Details = "The squirrel Books are the New World Books of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
			});

			Books.Add(new Book
			{
				Name = "Golden Lion Tamarin",
				Location = "Brazil",
				Details = "The golden lion tamarin also known as the golden marmoset, is a small New World Book of the family Callitrichidae.",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
			});

			Books.Add(new Book
			{
				Name = "Howler Book",
				Location = "South America",
				Details = "Howler Books are among the largest of the New World Books. Fifteen species are currently recognised. Previously classified in the family Cebidae, they are now placed in the family Atelidae.",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
			});

			Books.Add(new Book
			{
				Name = "Japanese Macaque",
				Location = "Japan",
				Details = "The Japanese macaque, is a terrestrial Old World Book species native to Japan. They are also sometimes known as the snow Book because they live in areas where snow covers the ground for months each",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
			});

			Books.Add(new Book
			{
				Name = "Mandrill",
				Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
				Details = "The mandrill is a primate of the Old World Book family, closely related to the baboons and even more closely to the drill. It is found in southern Cameroon, Gabon, Equatorial Guinea, and Congo.",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
			});

			Books.Add(new Book
			{
				Name = "Proboscis Book",
				Location = "Borneo",
				Details = "The proboscis Book or long-nosed Book, known as the bekantan in Malay, is a reddish-brown arboreal Old World Book that is endemic to the south-east Asian island of Borneo.",
				Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Book_in_Borneo.jpg/250px-Proboscis_Book_in_Borneo.jpg"
			});


			var sorted = from Book in Books
						 orderby Book.Name
						 group Book by Book.NameSort into BookGroup
						 select new Grouping<string, Book>(BookGroup.Key, BookGroup);

			BooksGrouped = new ObservableCollection<Grouping<string, Book>>(sorted);

		}
	}
}