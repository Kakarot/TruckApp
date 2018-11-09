using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TruckApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuPageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            SetNewDetail(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }

        public void SetNewDetail(Page page)
        {
            
            switch (page.Title)
            {
                case "Truck Items":
                    Detail = new NavigationPage(new TruckItems());
                    break;

                case "About":
                    Detail = new NavigationPage(new About());
                    break;

                default:
                    Detail = new NavigationPage(page);
                    break;
            }
        }
    }
}