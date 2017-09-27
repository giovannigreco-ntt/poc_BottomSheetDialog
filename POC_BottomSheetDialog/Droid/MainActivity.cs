using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.Design.Widget;

namespace POC_BottomSheetDialog.Droid
{
    [Activity(Label = "POC_BottomSheetDialog", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        BottomSheetDialog mBottomSheetDialog;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            mBottomSheetDialog = new BottomSheetDialog(this);
            View sheetView = LayoutInflater.Inflate(Resource.Layout.bottom_sheet_dialog, null);
            mBottomSheetDialog.SetContentView(sheetView);

            mBottomSheetDialog.FindViewById(Resource.Id.button_close).Click += (sender, ea) => {
                mBottomSheetDialog.Hide();
			};

			mBottomSheetDialog.FindViewById(Resource.Id.textView_action1).Click += (sender, ea) => {
                showToast(((TextView)sender).Text);
			};

            mBottomSheetDialog.FindViewById(Resource.Id.textView_action2).Click += (sender, ea) => {
            	showToast(((TextView)sender).Text);
            };

			mBottomSheetDialog.FindViewById(Resource.Id.textView_action3).Click += (sender, ea) => {
				showToast(((TextView)sender).Text);
			};

			mBottomSheetDialog.FindViewById(Resource.Id.textView_action4).Click += (sender, ea) => {
				showToast(((TextView)sender).Text);
			};

			Button button = FindViewById<Button>(Resource.Id.myButton);
			button.Text = "Open bottom sheet dialog";
			button.Click += delegate { mBottomSheetDialog.Show(); };
			
        }

		void showToast(string text)
		{
            Toast.MakeText(this, "Action " + text, ToastLength.Short).Show();
		}
    }
}

