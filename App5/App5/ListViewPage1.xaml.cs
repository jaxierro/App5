using App5.Droid.Model.Repositories;
using Https.request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage1 : ContentPage
    {
        public static DoctorsManager restManager { get; private set; }
        public static List<Doctors> items { get; private set; }
        // public ObservableCollection<string> Items { get; set; }

        public ListViewPage1()
        {
            InitializeComponent();


            restManager = new DoctorsManager(new RestService());


            items = restManager.GetTasksAsync();
            // List<Doctors> myData = JsonConvert.DeserializeObject<List<Doctors>>(json);

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
