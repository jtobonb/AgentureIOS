using System;

using UIKit;

namespace Agenture
{
    public partial class ViewController : UIViewController
    {
		//https://developer.xamarin.com/recipes/ios/standard_controls/popovers/display_a_loading_message/
		LoadingOverlay loadPop;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			var bounds = UIScreen.MainScreen.Bounds;

			// show the loading overlay on the UI thread using the correct orientation sizing
			loadPop = new LoadingOverlay(bounds); // using field from step 2
			//View.Add(loadPop);
            //loadPop.Hide();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        /*

        partial void ingresar(UIButton sender)
        {
            
            if (this.TextFieldUserLogin.Text == "" && this.TextFieldPasswLogin.Text == ""){
                UIAlertView _error = new UIAlertView("My Title Text", "This is my main text", null, "Ok", null);
                
            }
        }
        */
    }
}
