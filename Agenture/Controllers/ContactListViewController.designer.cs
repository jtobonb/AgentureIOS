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
    [Register ("ContactListViewController")]
    partial class ContactListViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem itemMenu { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView MainTable { get; set; }

        [Action ("showMenu:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void showMenu (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (itemMenu != null) {
                itemMenu.Dispose ();
                itemMenu = null;
            }

            if (MainTable != null) {
                MainTable.Dispose ();
                MainTable = null;
            }
        }
    }
}