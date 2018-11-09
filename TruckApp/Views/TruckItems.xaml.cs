using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TruckApp.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using TruckApp.Models;
using TruckApp.ViewModels;

namespace TruckApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TruckItems : ContentPage
    {

        public TruckItemsViewModel TruckItemsViewModels { get; set; }

        public TruckItems()
        {
            InitializeComponent();
            
            BindingContext = TruckItemsViewModels = new TruckItemsViewModel();
        }

         void OnAdd(object sender, System.EventArgs e)
        {
           
            
        }

        void OnUpdate(object sender, System.EventArgs e)
        {
        }

        void OnDelete(object sender, System.EventArgs e)
        {
        }

        private void NumberInStore_Completed(object sender, EventArgs e)
        {
           
           
           
            
        }
    }
}
