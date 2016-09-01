using System;
using System.Collections.Generic;
using UIKit;

namespace TestUIPageViewController
{
	public class PageDataSource : UIPageViewControllerDataSource
	{
		List<ContentViewController> pages; 

		public PageDataSource(List<ContentViewController> pages)
		{
			this.pages = pages;
		}

		override public UIViewController GetPreviousViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			ContentViewController currentPage = referenceViewController as ContentViewController;
			if(currentPage.Index == 0)
			{
				return pages[pages.Count - 1];
			}
			else
			{
				return pages[currentPage.Index - 1];
			}
		}

		override public UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
		{
			ContentViewController currentPage = referenceViewController as ContentViewController;
			return pages [(currentPage.Index + 1) % pages.Count];
		}
	}
}

