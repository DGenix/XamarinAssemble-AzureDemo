﻿using Android.App;
using Android.OS;
using Android.Views;
using AzureDemo.Core;
using MvvmCross.Droid.Support.V7.AppCompat;
using System;

namespace AzureDemo.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
	public class MainActivity : MvxAppCompatActivity<ListViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.activity_main);

			Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

			//FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
   //         fab.Click += FabOnClick;
		}

		public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        //private void FabOnClick(object sender, EventArgs eventArgs)
        //{
        //    View view = (View) sender;
        //    Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
        //        .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        //}
	}
}

