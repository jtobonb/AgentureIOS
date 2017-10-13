using System;
namespace Agenture
{
    public class ContactItemModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ContactItemModel(){}
        public ContactItemModel(string image, string title, string description)
        {
            this.Image = image;
            this.Title = title;
            this.Description = description;
        }
    }
}
