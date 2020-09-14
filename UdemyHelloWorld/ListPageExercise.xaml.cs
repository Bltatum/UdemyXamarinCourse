using System;
using System.Collections.Generic;
using UdemyHelloWorld.Models;
using UdemyHelloWorld.Services;
using Xamarin.Forms;

namespace UdemyHelloWorld
{
    public partial class ListPageExercise : ContentPage
    {
        private SearchService _searchService;
        private List<SearchGroup> _searchGroups;

        public ListPageExercise()
        {
            _searchService = new SearchService();

            InitializeComponent();

            PopulateListView(_searchService.GetRecentSearches());
        }

        void SearchBar_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            PopulateListView(_searchService.GetRecentSearches(e.NewTextValue));
        }

        void listView_Refreshing(System.Object sender, System.EventArgs e)
        {
            PopulateListView(_searchService.GetRecentSearches(searchBar.Text));

            listView.EndRefresh();
        }

        void listView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Selected", search.Location, "Ok");
        }

        void Delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;

            _searchGroups[0].Remove(search);

            _searchService.DeleteSearch(search.Id);
        }

        private void PopulateListView(IEnumerable<Search> searches)
        {
            _searchGroups = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", searches)
            };

            listView.ItemsSource = _searchGroups;
        }
    }
}
