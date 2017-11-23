using CarouselView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarouselView.ViewModels
{
	//public
	class ProductViewModel
	{
		public ObservableCollection<Product> Products { get; set; }
		public Product _oldProduct;

		public ProductViewModel()
		{

			Products = new ObservableCollection<Product>
			{
				new Product {
					Title = "Surface Laptop",
					IsVisible = false
				},

				new Product
				{
					Title = "Surface Laptop",
					IsVisible = false
				},

				new Product
				{
					Title = "X1 Carbon",
					IsVisible = false
				}
			};
		}

		internal void HideOrShowProduct(Product product)
		{
			product.IsVisible = true;

			UpdateProduct(product);

			_oldProduct = product;
		}

		private void UpdateProduct(Product product)
		{
			Products.Remove(product);
			Products.Insert(Products.IndexOf(product), product);
		}
	}
}
