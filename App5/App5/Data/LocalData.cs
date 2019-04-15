using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace App5.Droid.Data
{
   
    public class LocalData
    {
        SQLiteConnection _db;

        public LocalData()
        {
            _db = MainActivity.Instance.DBConnection();
        }


        //public void AddColonia(Colonia colonia)
        //{
        //    try
        //    {
        //        _db.CreateTable<Colonia>();
        //        _db.Insert(colonia);

        //    }
        //    catch (Exception ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine(ex.Message);
        //    }
        //}

        //public List<Colonia> AllColonias()
        //{
        //    var listaColonias = new List<Colonia>();
        //    try
        //    {
        //        var dbColonias = _db.Table<Colonia>();
        //        foreach (var colonia in dbColonias)
        //        {
        //            listaColonias.Add(colonia);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Diagnostics.Debug.Write(ex.Message);
        //    }
        //    return listaColonias;
        //}


    }
}