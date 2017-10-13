using Foundation;
using System;
using UIKit;

namespace Agenture
{
    public partial class DetailContactViewController : UIViewController
    {
        public ContactItemModel model = new ContactItemModel();

        public DetailContactViewController (IntPtr handle) : base (handle)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.detailIdentificacion.Text = model.Image;
            this.detailNombre.Text = model.Title;
            this.detailApellido.Text = model.Description;


        }

    }
}