using Foundation;
using System;
using UIKit;

namespace Agenture
{
    public partial class itemTableViewController : UITableViewCell
    {
        public itemTableViewController (IntPtr handle) : base (handle)
        {
        }

        internal void updateCell(ContactItemModel dataThing)
        {
            this.imageViewItem.Image = UIImage.FromFile((String)dataThing.Image);
            this.labelTitle.Text = (String)dataThing.Title;
            this.labelDescription.Text = (String)dataThing.Description;

            //this.imageViewItem.Layer.CornerRadius = this.imageViewItem.Frame.Size.Width / 2;
        }
    }
}