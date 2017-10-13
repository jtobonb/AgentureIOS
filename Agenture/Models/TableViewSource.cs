using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace Agenture
{
    internal class TableViewSource : UITableViewSource
    {
        private List<ContactItemModel> modelList;
        private IContactItem contactItem;
        
        public TableViewSource(List<ContactItemModel> modelList, IContactItem _contactItem)
        {
            this.modelList = modelList;
            this.contactItem = _contactItem;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (itemTableViewController)tableView.DequeueReusableCell("itemCell", indexPath);
            var dataThing = modelList[indexPath.Row];
            cell.updateCell(dataThing);
            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            contactItem.selection(modelList[indexPath.Row]);
            //base.RowSelected(tableView, indexPath);
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return modelList.Count;
        }
    }
}