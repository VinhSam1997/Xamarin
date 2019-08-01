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

namespace FruitMatching
{
    [Activity(Label = "PlayPage")]
    public class PlayPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Playpage);
            string textname = Intent.GetStringExtra("name" ?? "Not valid");

            var username = FindViewById<TextView>(Resource.Id.username);
            var userscore = FindViewById<TextView>(Resource.Id.score);
            var backbutton = FindViewById<Button>(Resource.Id.back);

            username.Text = textname;
            backbutton.Click += delegate
            {
                this.Finish();
            };
        }
    }
}