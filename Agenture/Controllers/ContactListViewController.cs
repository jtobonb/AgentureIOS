using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace Agenture
{
    public partial class ContactListViewController : UIViewController, IContactItem
    {
        List<ContactItemModel> modelList;
        public ContactItemModel itemModel;

        public ContactListViewController (IntPtr handle) : base (handle)
        {
            
        }

        public void selection(ContactItemModel model)
        {
            this.itemModel = model;
            PerformSegue("SegueDetalleUsuario", null);
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier.Equals("SegueDetalleUsuario"))
            {
                DetailContactViewController detail = (DetailContactViewController)segue.DestinationViewController;
                detail.model= itemModel;
            }
        }

        public override void ViewDidLoad()
        {
			base.ViewDidLoad();
            modelList = new List<ContactItemModel>
			{
                new ContactItemModel("accenturelogo.png", "nombre1", "descripcion1"),
				new ContactItemModel("accenturelogo.png", "nombre2", "descripcion2"),
				new ContactItemModel("accenturelogo.png", "nombre3", "descripcion3")
			};
            this.MainTable.Source = new TableViewSource(modelList, this);
        }


        partial void showMenu(UIBarButtonItem sender)
        {
            MenuRootViewController.SidebarMenuController.ToggleMenu();
        }
    }
}