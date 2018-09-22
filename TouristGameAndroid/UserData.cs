using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TouristGameAndroid
{
    class UserData
    {

        public string Name { get; set; }
        public string Email { get; set; }

        public UserData(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + " " + Email;
        }

    }
}