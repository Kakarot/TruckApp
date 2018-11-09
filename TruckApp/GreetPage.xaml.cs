using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruckApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new TruckItems();
        }
    }
}