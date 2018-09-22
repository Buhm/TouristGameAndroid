using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using TouristGameAndroid.Resources.layout;

namespace TouristGameAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme.Splash")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.ja_button);

            button.Click += delegate
            {
                var intent = new Intent(this, typeof(nietherinneren_main));
                StartActivity(intent);
            };


            Button button2 = FindViewById<Button>(Resource.Id.nee_button);

            button2.Click += delegate
            {
                var intent = new Intent(this, typeof(mooiestad_intro));
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
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

