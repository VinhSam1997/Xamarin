using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace FruitMatching
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnplay = FindViewById<Button>(Resource.Id.play);
            var btnscore = FindViewById<Button>(Resource.Id.score);

            btnplay.Click += (s, e) =>
            {
                Intent nextPage = new Intent(this, typeof(ReadyPage));
                StartActivity(nextPage);
            };
        }
        
    }
}
