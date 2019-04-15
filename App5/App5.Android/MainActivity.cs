using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SQLite;
using System.IO;

namespace App5.Droid
{
    [Activity(Label = "App5", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        SQLiteConnection _conection;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        static MainActivity _instance;
        public static MainActivity Instance
        {
            get
            {
                return _instance;
            }
        }

        public SQLiteConnection DBConnection()
        {
            try
            {
                if (_conection == null)
                {
                    string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "primerRespondiente.db3"); //Call Database  
                    _conection = new SQLiteConnection(dpPath);
                }

                return _conection;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }
}