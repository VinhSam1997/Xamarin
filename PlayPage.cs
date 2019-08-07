using System;
using System.Timers;
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
        private TextView timeup;
        private int count = 50;
        Timer timer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Playpage);
            string textname = Intent.GetStringExtra("name" ?? "Not valid");

            var username = FindViewById<TextView>(Resource.Id.username);
            var userscore = FindViewById<TextView>(Resource.Id.score);
            var backbutton = FindViewById<Button>(Resource.Id.back);
            timeup = FindViewById<TextView>(Resource.Id.time);

            ImageButton btn1 = FindViewById<ImageButton>(Resource.Id.box1);
            ImageButton btn2 = FindViewById<ImageButton>(Resource.Id.box2);
            ImageButton btn3 = FindViewById<ImageButton>(Resource.Id.box3);
            ImageButton btn4 = FindViewById<ImageButton>(Resource.Id.box4);
            ImageButton btn5 = FindViewById<ImageButton>(Resource.Id.box5);
            ImageButton btn6 = FindViewById<ImageButton>(Resource.Id.box6);
            ImageButton btn7 = FindViewById<ImageButton>(Resource.Id.box7);
            ImageButton btn8 = FindViewById<ImageButton>(Resource.Id.box8);

            int count = 0;
            string fruit1 = "";
            string fruit2 = "";
            int score = 0;

            username.Text = textname;

            btn1.Click += delegate
            {
                btn1.SetImageResource(Resource.Drawable.Apple);
                count = count + 1;

                if (count == 1)
                {
                    fruit1 = "Apple";
                }

                if (count == 2)
                {
                    count = 0;
                    fruit2 = "Apple";
                    if (fruit1 == fruit2)
                    {
                        score = score + 10;
                        fruit1 = "";
                        fruit2 = "";
                        userscore.Text = "Score: " + score;
                    }
                    else
                    {
                        fruit2 = "";
                        count = 1;
                        btn1.SetImageResource(Resource.Drawable.HiddenBox);
                    }
                }
            };

            btn2.Click += delegate
            {
                btn2.SetImageResource(Resource.Drawable.Watermelon);
                count = count + 1;
                if (count == 1)
                {
                    fruit1 = "Watermelon";
                }

                if (count == 2)
                {
                    count = 0;
                    fruit2 = "Watermelon";
                    if (fruit1 == fruit2)
                    {
                        score = score + 10;
                        fruit1 = "";
                        fruit2 = "";
                        userscore.Text = "Score: " + score;
                    }
                    else
                    {
                        fruit2 = "";
                        count = 1;
                        btn2.SetImageResource(Resource.Drawable.HiddenBox);
                    }
                }
            };

            btn3.Click += delegate
            {
                btn3.SetImageResource(Resource.Drawable.Pineapple);
                count = count + 1;
                if (count == 1)
                {
                    fruit1 = "Pineapple";
                }

                if (count == 2)
                {
                    count = 0;
                    fruit2 = "Pineapple";
                    if (fruit1 == fruit2)
                    {
                        score = score + 10;
                        fruit1 = "";
                        fruit2 = "";
                        userscore.Text = "Score: " + score;
                    }
                    else
                    {
                        fruit2 = "";
                        count = 1;
                        btn3.SetImageResource(Resource.Drawable.HiddenBox);
                    }
                }
            };

            btn4.Click += delegate
            {
                btn4.SetImageResource(Resource.Drawable.Orange);
                count = count + 1;
                if (count == 1)
                {
                    fruit1 = "Orange";
                }

                if (count == 2)
                {
                    count = 0;
                    fruit2 = "Orange";
                    if (fruit1 == fruit2)
                    {
                        score = score + 10;
                        fruit1 = "";
                        fruit2 = "";
                        userscore.Text = "Score: " + score;
                    }
                    else
                    {
                        fruit2 = "";
                        count = 1;
                        btn4.SetImageResource(Resource.Drawable.HiddenBox);
                    }
                }
            };

            btn5.Click += delegate
            {
                btn5.SetImageResource(Resource.Drawable.Apple);
                count = count + 1;
                if (count == 1)
                {
                    fruit1 = "Apple";
                }

                if (count == 2)
                {
                    count = 0;
                    fruit2 = "Apple";
                    if (fruit1 == fruit2)
                    {
                        score = score + 10;
                        fruit1 = "";
                        fruit2 = "";
                        userscore.Text = "Score: " + score;
                    }
                    else
                    {
                        fruit2 = "";
                        count = 1;
                        btn5.SetImageResource(Resource.Drawable.HiddenBox);
                    }
                }
            };

            btn6.Click += delegate
            {
                btn6.SetImageResource(Resource.Drawable.Watermelon);
                count = count + 1;
                if (count == 1)
                {
                    fruit1 = "Watermelon";
                }

                if (count == 2)
                {
                    count = 0;
                    fruit2 = "Watermelon";
                    if (fruit1 == fruit2)
                    {
                        score = score + 10;
                        fruit1 = "";
                        fruit2 = "";
                        userscore.Text = "Score: " + score;
                    }
                    else
                    {
                        fruit2 = "";
                        count = 1;
                        btn6.SetImageResource(Resource.Drawable.HiddenBox);
                    }
                }
            };

            btn7.Click += delegate
            {
                btn7.SetImageResource(Resource.Drawable.Orange);
                count = count + 1;
                if (count == 1)
                {
                    fruit1 = "Orange";
                }

                if (count == 2)
                {
                    count = 0;
                    fruit2 = "Orange";
                    if (fruit1 == fruit2)
                    {
                        score = score + 10;
                        fruit1 = "";
                        fruit2 = "";
                        userscore.Text = "Score: " + score;
                    }
                    else
                    {
                        fruit2 = "";
                        count = 1;
                        btn7.SetImageResource(Resource.Drawable.HiddenBox);
                    }
                }
            };

            btn8.Click += delegate
            {
                btn8.SetImageResource(Resource.Drawable.Pineapple);
                count = count + 1;
                if (count == 1)
                {
                    fruit1 = "Pineapple";
                }

                if (count == 2)
                {
                    count = 0;
                    fruit2 = "Pineapple";
                    if (fruit1 == fruit2)
                    {
                        score = score + 10;
                        fruit1 = "";
                        fruit2 = "";
                        userscore.Text = "Score: ";
                    }
                    else
                    {
                        fruit2 = "";
                        count = 1;
                        btn8.SetImageResource(Resource.Drawable.HiddenBox);
                    }
                }
            };

            backbutton.Click += delegate
            {
                this.Finish();
            };
        }

        protected override void OnResume()
        {
            base.OnResume();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Intent turnback = new Intent(this, typeof(ReadyPage));
            if (count > 0 && count <= 50)
            {
                count--;
                RunOnUiThread(() => {
                    timeup.Text = "Time: " + count;
                });
                if (count == 0)
                {
                    StartActivity(turnback);
                }
            }
            
        }
    }
}
