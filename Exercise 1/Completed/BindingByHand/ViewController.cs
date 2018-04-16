using System;
using System.Diagnostics;
using UIKit;

namespace BindingByHand {
	public partial class ViewController : UIViewController {
		protected ViewController(IntPtr handle) : base(handle) {
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			Weather myWeather = new Weather();

			myWeather.CurrentTemperature = 99f;

			Debug.WriteLine(myWeather.CurrentTemperature);
		}

		public override void DidReceiveMemoryWarning() {
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
