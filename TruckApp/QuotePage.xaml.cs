using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruckApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotePage : ContentPage
	{
		public QuotePage ()
		{
			InitializeComponent ();
        
            var grid = new Grid
            {
                RowSpacing = 5,
                ColumnSpacing = 5
            };
            var label = new Label { Text = "Label 1", TextColor = Color.White};
            grid.Children.Add(label, 0, 0);
            grid.Children.Add(new Label { Text = "Label 2", TextColor = Color.White }, 1, 1);
            grid.Children.Add(new Label { Text = "Label 3", TextColor = Color.White }, 0, 2);
            grid.Children.Add(new Label { Text = "Label 4", TextColor = Color.White }, 0, 3);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 15; j++)
                grid.Children.Add(new Label { Text = "Label " + i + " " + j, TextColor = Color.White, BackgroundColor = Color.Gray }, i, j);
            }
            Content = grid;
        }


	}
}