using Foundation;
using System;
using UIKit;
using SidebarNavigation;

namespace Agenture
{
    public partial class MenuRootViewController : UIViewController
    {
        public static SidebarController SidebarMenuController { get; private set; }

        public MenuRootViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			var productsSB = UIStoryboard.FromName("Main", null);
            var productsNavigation = productsSB.InstantiateViewController("ContactListNavigation");

            var menuViewController = Storyboard.InstantiateViewController("MenuViewController");
            SidebarMenuController = new SidebarController(this, productsNavigation, menuViewController);
            SidebarMenuController.HasShadowing = false;
            SidebarMenuController.MenuWidth = (int)UIScreen.MainScreen.Bounds.Width - 0;
        }
    }
}