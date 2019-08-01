using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;


namespace FruitMatching
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class ReadyPage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Ready);
            var btnOK = FindViewById<Button>(Resource.Id.OK);
            var username = FindViewById<EditText>(Resource.Id.textname);

            btnOK.Click += (s, e) =>
            {
                Intent gamePage = new Intent(this, typeof(PlayPage));
                StartActivity(gamePage);
            };
        }
    }
}