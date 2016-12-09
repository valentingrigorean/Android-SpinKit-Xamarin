using Android.App;
using Android.Widget;
using Android.OS;
using Com.Github.Ybq.Android.Spinkit.Style;

namespace SkinKitTest
{
    [Activity(Label = "SkinKitTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

			var progressBar = (ProgressBar)FindViewById(Resource.Id.spin_kit);
			var doubleBounce = new DoubleBounce();
			progressBar.IndeterminateDrawable = doubleBounce;

        }
    }
}

