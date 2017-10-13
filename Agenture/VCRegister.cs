using Foundation;
using System;
using UIKit;

namespace Agenture
{
    public partial class VCRegister : UIViewController
    {
        public VCRegister (IntPtr handle) : base (handle)
        {
        }

        partial void registrar(UIButton sender)
        {
            UIStoryboard menuSB = UIStoryboard.FromName("Menu", null);
            var menuRootViewController = menuSB.InstantiateViewController("MenuRootViewController");
            View.Window.RootViewController = menuRootViewController;
            return;
        }
    }
}