using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TruckApp.Models;
using Xamarin.Forms;
using System.ComponentModel;
using SQLite;
using TruckApp.Database;
using System.Runtime.CompilerServices;

namespace TruckApp.ViewModels
{
    public class TruckItemsViewModel : BaseViewModel
    {
      
        public ObservableCollection<TruckItem> FoodItem { get; set; } = new ObservableCollection<TruckItem>();
        
        public TruckItemsViewModel()
        {
            TruckItemCRUD truckItemCRUD = new TruckItemCRUD();
            
            FoodItem = truckItemCRUD.ListOfItems;

        }

    }
}
