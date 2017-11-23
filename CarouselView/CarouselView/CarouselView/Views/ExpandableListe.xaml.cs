using CarouselView.Models;
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
	public partial class ExpandableListe : ContentPage
	{
		public ExpandableListe()
		{
			InitializeComponent();
		}

		//private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		//{
		//	var vm = BindingContext as ProductViewModel;

		//	var product = e.Item as Product;

		//	vm.HideOrShowProduct(product);

		//}
	}
}