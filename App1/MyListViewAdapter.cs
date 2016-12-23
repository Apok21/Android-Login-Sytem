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

namespace App1
{
    class MyListViewAdapter : BaseAdapter<Person>
    {
        public List<Person> mItems;
        private Context mContext;
        public MyListViewAdapter(Context context, List<Person> items)
        {
            mContext = context;
            mItems = items;
        }
        public override int Count
        {
            get
            {
                return (mItems.Count);
            }
        }
        public override long GetItemId(int position)
        {
              return position;
        }
        public override Person this[int position]
        {
            get
            {
                return mItems[position];
            }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row==null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListView_Row,null,false);
            }
            TextView txtFirstName = row.FindViewById<TextView>(Resource.Id.textFirstName);
            txtFirstName.Text = mItems[position].FirstName;
            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.textLastName);
            txtLastName.Text = mItems[position].LastName;
            TextView txtAge = row.FindViewById<TextView>(Resource.Id.textAge);
            txtAge.Text = mItems[position].Age;
            TextView txtGender = row.FindViewById<TextView>(Resource.Id.textGender);
            txtGender.Text = mItems[position].Gender;
            return row;
        }
    }
}