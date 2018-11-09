using SQLite;
using System;
using System.Collections.ObjectModel;
using TruckApp.Database;
using Xamarin.Forms;

namespace TruckApp
{

	public class Recipe 
	{
        [PrimaryKey, AutoIncrement]
		public int Id { get; set; }
        [MaxLength(255)]
		public string Name  { get; set; }
	}

	public partial class Mosh : ContentPage
	{
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;

        public Mosh()
		{
			InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
		}

        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Recipe>();

            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;

            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
		{
            var recipe = new Recipe { Name = "Recipe " + DateTime.Now.Ticks };

            await _connection.InsertAsync(recipe);

            _recipes.Add(recipe);

		}

		void OnUpdate(object sender, System.EventArgs e)
		{
		}

		void OnDelete(object sender, System.EventArgs e)
		{
		}
	}
}