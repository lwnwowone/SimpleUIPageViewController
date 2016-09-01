using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace TestUIPageViewController
{
	public class MyPageViewController : UIPageViewController
	{
		private List<ContentViewController> pages = new List<ContentViewController> ();

		public MyPageViewController () : base (UIPageViewControllerTransitionStyle.Scroll, UIPageViewControllerNavigationOrientation.Horizontal)
		{
			View.Frame = UIScreen.MainScreen.Bounds;
			ContentViewController cvc0 = new ContentViewController (0, UIColor.Red);
			cvc0.View.AddGestureRecognizer (new UITapGestureRecognizer (() => {
				new UIAlertView("Error", "Please enter all the required details.", null, "OK", null).Show();
			}));
			pages.Add (cvc0);
			pages.Add (new ContentViewController(1,UIColor.Green));
			pages.Add (new ContentViewController(2,UIColor.Blue));
			DataSource = new PageDataSource (pages);
			SetViewControllers (new UIViewController[] { pages [0] as UIViewController }, UIPageViewControllerNavigationDirection.Forward, false, null);
		}
	}
}

