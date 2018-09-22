using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;

namespace TouristGameAndroid
{
    [Activity(Label = "npcsjeng_intro")]
    public class NpcSjengIntro : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.npcsjeng_intro);


            //getbuttonfromlayoutresource
            //and attach event to it

            Button buttonAangenaam = FindViewById<Button>(Resource.Id.aangenaam);

            buttonAangenaam.Click += delegate
            {
                /*
                //path string for the database file
                string dbpath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dbTest.db3");
                //setup connection
                var db = new SQLiteConnection(dbpath);

                //setup a table
                db.CreateTable<UserData>();
                UserData User = new UserData("Remco", "r.lebon@gmail.com");

                //store the object into the table
                db.Insert(User);
                */

                var intent = new Intent(this, typeof(KomMeeIntro));
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
        }
        // Create your application here



    }

}
