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
           

            ImageButton btn1 = FindViewById<ImageButton>(Resource.Id.box1);
            ImageButton btn2 = FindViewById<ImageButton>(Resource.Id.box2);
            ImageButton btn3 = FindViewById<ImageButton>(Resource.Id.box3);
            ImageButton btn4 = FindViewById<ImageButton>(Resource.Id.box4);
            ImageButton btn5 = FindViewById<ImageButton>(Resource.Id.box5);
            ImageButton btn6 = FindViewById<ImageButton>(Resource.Id.box6);
            ImageButton btn7 = FindViewById<ImageButton>(Resource.Id.box7);
            ImageButton btn8 = FindViewById<ImageButton>(Resource.Id.box8);


            username.Text = textname;

            btn1.Click += delegate
            {
                btn1.SetImageResource(Resource.Drawable.Apple);
            };

            btn2.Click += delegate
            {
                btn2.SetImageResource(Resource.Drawable.Watermelon);
            };

            btn3.Click += delegate
            {
                btn3.SetImageResource(Resource.Drawable.Pineapple);
            };

            btn4.Click += delegate
            {
                btn4.SetImageResource(Resource.Drawable.Orange);
            };

            btn5.Click += delegate
            {
                btn5.SetImageResource(Resource.Drawable.Apple);
            };

            btn6.Click += delegate
            {
                btn6.SetImageResource(Resource.Drawable.Watermelon);
            };

            btn7.Click += delegate
            {
                btn7.SetImageResource(Resource.Drawable.Orange);
            };

            btn8.Click += delegate
            {
                btn8.SetImageResource(Resource.Drawable.Pineapple);
            };

            backbutton.Click += delegate
            {
                this.Finish();
            };
        }
    }
}