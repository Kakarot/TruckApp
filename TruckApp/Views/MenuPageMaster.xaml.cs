using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Models;
using TruckApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruckApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPageMaster : ContentPage
    {
        public ListView ListView;

        public MenuPageMaster()
        {
            InitializeComponent();

            BindingContext = new MenuPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MenuPageMasterViewModel : BaseViewModel
        {
            public ObservableCollection<MenuPageMenuItem> MenuItems { get; set; }
            
            public MenuPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuPageMenuItem>(new[]
                {
                    new MenuPageMenuItem { Id = 0, Title = "About" },
                    new MenuPageMenuItem { Id = 1, Title = "Add Truck Items" },
                    new MenuPageMenuItem { Id = 2, Title = "Truck Items" },
                    new MenuPageMenuItem { Id = 3, Title = "Truck Calculations" },
                    new MenuPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
           
        }
    }
}