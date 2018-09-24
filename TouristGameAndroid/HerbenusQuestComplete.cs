﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.Design.Widget;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TouristGameAndroid
{
    [Activity(Label = "HerbenusQuestComplete")]
    public class HerbenusQuestComplete : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.herbenus_quest_complete);


            Button button = FindViewById<Button>(Resource.Id.geen_zorgen);

            button.Click += delegate
            {
                var intent = new Intent(this, typeof(SjengQuestComplete));
                StartActivity(intent);
            };



            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
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

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
            .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
            // Create your application here
        }
    }
}