using System;
using System.Collections.Generic;
using UdemyHelloWorld.Models;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;

namespace UdemyHelloWorld
{
    public partial class ListPage : ContentPage
    {
        private ObservableCollection<Contacts> _contacts;

        public ListPage()
        {
            InitializeComponent();

            listview.ItemsSource = GetContacts();
            //to group by name
            //listview.ItemsSource = new List<ContactGroup>
            //{
            //    new ContactGroup("M", "M")
            //    {
            //         new Contacts {Name = "Mosh", ImageUrl = "https://via.placeholder.com/100"}
            //    },

            //   new ContactGroup("B", "B")
            //   {
            //         new Contacts {Name = "Brennen", ImageUrl = "https://via.placeholder.com/100", Status = "Hey leys talk"}
            //   }
            //};

            //For app to refresh component.
            //_contacts = new ObservableCollection<Contacts>
            //{
            //    new Contacts {Name = "Mosh", ImageUrl = "https://via.placeholder.com/100"},
            //     new Contacts {Name = "Brennen", ImageUrl = "https://via.placeholder.com/100", Status = "Hey leys talk"}
            //};

            //listview.ItemsSource = _contacts;


        }
        //for selected event handler
        //void listview_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    var contact = e.SelectedItem as Contacts;
        //    DisplayAlert("Selected", contact.Name, "Ok");
            
        //}

        //hardcoding contacts for search test.
        IEnumerable<Contacts> GetContacts(string searchText = null)
        {
            var contacts = new List<Contacts>
            {
                new Contacts {Name = "Mosh", ImageUrl = "https://via.placeholder.com/100"},
                new Contacts {Name = "Brennen", ImageUrl = "https://via.placeholder.com/100", Status = "Hey leys talk"}
            };
            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

              return contacts.Where(c => c.Name.StartsWith(searchText));
        }
        //call button event handler
        void Call_Clicked(System.Object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contacts;
            DisplayAlert("Call", contact.Name, "Ok");
        }
        //delete button event handler
        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contactToDelete = (sender as MenuItem).CommandParameter as Contacts;
            _contacts.Remove(contactToDelete);
        }
        //search event handler
        void SearchBar_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listview.ItemsSource = GetContacts(e.NewTextValue);
        }
        //for item tapped event
        //void listview_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        //{
        //    var contact = e.Item as Contacts;
        //    DisplayAlert("Tapped", contact.Name, "Ok");
        //}

    }
}
