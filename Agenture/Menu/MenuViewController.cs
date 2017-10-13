using Foundation;
using System;
using UIKit;
using System.Threading.Tasks;

namespace Agenture
{
    public partial class MenuViewController : UIViewController
    {
        private static MenuItem currentMenuItem;

        partial void btnQueriesPressed(UIButton sender)
        {
            var registrar = UIStoryboard.FromName("Main", null);
            var registrarNavigation = registrar.InstantiateViewController("registrarNavigation");
            MenuRootViewController.SidebarMenuController.ChangeContentView(registrarNavigation);
        }

        public MenuViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
          
		}

        void Logout()
        {
            
        }

        partial void btnClosePressed(UIButton sender)
        {
            MenuRootViewController.SidebarMenuController.ToggleMenu();
        }

        partial void CloseSesionPressed(UIButton sender)
        {
			MenuRootViewController.SidebarMenuController.ToggleMenu();
        }

        public static void SetCurrentItem(MenuItem item)
        {
            currentMenuItem = item;
        }
    }

    public enum MenuItem
    {
        CONTACTOS
    }
}