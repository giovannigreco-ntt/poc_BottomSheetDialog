using System;
using Android.Content;
using Android.Util;
using Android.Widget;

namespace POC_BottomSheetDialog.Droid
{
    public class BottomSheetDialogListView : ListView
    {
        public BottomSheetDialogListView(Context context, IAttributeSet p_attrs) : base(context, p_attrs)
		{
            
		}

        public override bool OnInterceptTouchEvent(Android.Views.MotionEvent ev)
        {
            return true;
        }

        public override bool OnTouchEvent(Android.Views.MotionEvent e)
        {
            if ((CanScrollVertically(-1)) || (CanScrollVertically(1)))
            {
                Parent.RequestDisallowInterceptTouchEvent(true);
            }
            return base.OnTouchEvent(e);

		}

	
        public override bool CanScrollVertically(int direction)
        {
			bool canScroll = false;

			if (ChildCount > 0)
			{
				bool isOnTop = FirstVisiblePosition != 0 || GetChildAt(0).Top != 0;
				bool isAllItemsVisible = isOnTop && LastVisiblePosition == ChildCount;

				if (isOnTop || isAllItemsVisible)
				{
					canScroll = true;
				}
			}

			return canScroll;


        }

	


    }
}
