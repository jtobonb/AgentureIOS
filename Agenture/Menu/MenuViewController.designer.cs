// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Agenture
{
    [Register ("MenuViewController")]
    partial class MenuViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCloseMenu { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLogout { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnQueries { get; set; }

        [Action ("btnClosePressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnClosePressed (UIKit.UIButton sender);

        [Action ("btnQueriesPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnQueriesPressed (UIKit.UIButton sender);

        [Action ("CloseSesionPressed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CloseSesionPressed (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnCloseMenu != null) {
                btnCloseMenu.Dispose ();
                btnCloseMenu = null;
            }

            if (btnLogout != null) {
                btnLogout.Dispose ();
                btnLogout = null;
            }

            if (btnQueries != null) {
                btnQueries.Dispose ();
                btnQueries = null;
            }
        }
    }
}