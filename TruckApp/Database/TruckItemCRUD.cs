using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SQLite;
using Xamarin.Forms;
using TruckApp.Models;
using System.Threading.Tasks;

namespace TruckApp.Database
{
    class TruckItemCRUD
    {
        //Get connection to Database
        private SQLiteAsyncConnection _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

        //Declares an observableCollection
        private ObservableCollection<TruckItem> _ListOfItems;

        //stores a list from the database
        public ObservableCollection<TruckItem> ListOfItems
        {
            get
            {
                GetObCol();
                return _ListOfItems;
            }

            set
            {
               
            }
        }

        //When called it will auto check for the table
        public TruckItemCRUD()
        {
            CreateTable();
        }

        //Checks to see if table exist and if not creates it
        private async void CreateTable()
        {
            await _connection.CreateTableAsync<TruckItem>();
        }

        //Inserts into the database
        public async void InsertItem(TruckItem truckItem)
        {
            await _connection.InsertAsync(truckItem);
        }

        //updates the database
        public async void UpdateItem(TruckItem truckItem)
        {
            await _connection.UpdateAsync(truckItem);
        }

        //Deletes the item from the database
        public async void DeleteItem(TruckItem truckItem)
        {
            await _connection.DeleteAsync(truckItem);
        }

        //returns a ObservableCollection from the database
        public async void GetObCol()
        {
            _ListOfItems = new ObservableCollection<TruckItem>();
            var TruckItems = await _connection.Table<TruckItem>().ToListAsync();
            foreach (var truckItem in TruckItems)
            {
                _ListOfItems.Add(truckItem);
            }
        }

    }
}