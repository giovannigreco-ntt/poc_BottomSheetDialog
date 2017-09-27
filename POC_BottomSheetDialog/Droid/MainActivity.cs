using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using Android.Support.Design.Widget;
using Android.Graphics;

namespace POC_BottomSheetDialog.Droid
{
    [Activity(Label = "POC_BottomSheetDialog", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
		BottomSheetDialog staticBottomSheetDialog;
		BottomSheetDialog listViewBottomSheetDialog;

		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            staticBottomSheetDialog = new BottomSheetDialog(this);
            View staticSheetView = LayoutInflater.Inflate(Resource.Layout.static_bottom_sheet_dialog, null);
            staticBottomSheetDialog.SetContentView(staticSheetView);

            staticBottomSheetDialog.FindViewById(Resource.Id.button_close).Click += (sender, ea) => {
                staticBottomSheetDialog.Hide();
			};

			staticBottomSheetDialog.FindViewById(Resource.Id.textView_action1).Click += (sender, ea) => {
                showToast(((TextView)sender).Text);
			};

            staticBottomSheetDialog.FindViewById(Resource.Id.textView_action2).Click += (sender, ea) => {
            	showToast(((TextView)sender).Text);
            };

			staticBottomSheetDialog.FindViewById(Resource.Id.textView_action3).Click += (sender, ea) => {
				showToast(((TextView)sender).Text);
			};

			staticBottomSheetDialog.FindViewById(Resource.Id.textView_action4).Click += (sender, ea) => {
				showToast(((TextView)sender).Text);
			};

            Button button = FindViewById<Button>(Resource.Id.button_static);
			button.Click += delegate { staticBottomSheetDialog.Show(); };




            listViewBottomSheetDialog = new BottomSheetDialog(this);
            View listSheetView = LayoutInflater.Inflate(Resource.Layout.list_view_bottom_sheet_dialog, null);
			listViewBottomSheetDialog.SetContentView(listSheetView);

			listViewBottomSheetDialog.FindViewById(Resource.Id.button_close).Click += (sender, ea) => {
				listViewBottomSheetDialog.Hide();
			};

            string[] items = new string[] { GetString(Resource.String.bottom_sheet_dialog_action1),
                                            GetString(Resource.String.bottom_sheet_dialog_action2),
                                            GetString(Resource.String.bottom_sheet_dialog_action3),
                                            GetString(Resource.String.bottom_sheet_dialog_action4),
                                            GetString(Resource.String.bottom_sheet_dialog_action5),
                                            GetString(Resource.String.bottom_sheet_dialog_action6),
                                            GetString(Resource.String.bottom_sheet_dialog_action7),
                                            GetString(Resource.String.bottom_sheet_dialog_action8),
                                            GetString(Resource.String.bottom_sheet_dialog_action9),
                                            GetString(Resource.String.bottom_sheet_dialog_action10),
                                            GetString(Resource.String.bottom_sheet_dialog_action11),
                                            GetString(Resource.String.bottom_sheet_dialog_action12)  };
            
			ArrayAdapter<string> ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);

            BottomSheetDialogListView listView = listViewBottomSheetDialog.FindViewById<BottomSheetDialogListView>(Resource.Id.listView);
            listView.SetBackgroundColor(Color.Blue);
            listView.Adapter = ListAdapter;

			Button buttonList = FindViewById<Button>(Resource.Id.button_list);
			buttonList.Click += delegate { listViewBottomSheetDialog.Show(); };
			
        }

		void showToast(string text)
		{
            Toast.MakeText(this, "Action " + text, ToastLength.Short).Show();
		}
    }
}

