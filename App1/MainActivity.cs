using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Person> items;
        private ListView mylistview;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mylistview = FindViewById<ListView>(Resource.Id.listView1);
            items = new List<Person>();
            items.Add(new Person() { FirstName = "Amrit", LastName = "Thapaliya", Age = "24", Gender = "Male" });
            items.Add(new Person() { FirstName = "Bob", LastName = "Taylor", Age = "30", Gender = "Male" });
            items.Add(new Person() { FirstName = "Alis", LastName = "Kane", Age = "24", Gender = "Female" });
            MyListViewAdapter adapter = new MyListViewAdapter(this, items);
            mylistview.Adapter = adapter;
            mylistview.ItemClick += Mylistview_ItemClick;
            //mylistview.ItemClick -= Mylistview_ItemClick;
            mylistview.ItemLongClick += Mylistview_ItemLongClick;


        }

        private void Mylistview_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(items[e.Position].FirstName + " " + items[e.Position].LastName);
        }

        private void Mylistview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(items[e.Position].FirstName);
        }
    }
}

