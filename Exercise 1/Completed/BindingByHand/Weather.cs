using System;
using Foundation;
using ObjCRuntime;

namespace BindingByHand {
	[Register("Weather", true)]
	public class Weather : NSObject {
		static readonly IntPtr class_ptr = Class.GetHandle("Weather");
		public override IntPtr ClassHandle { get { return class_ptr; } }

		[Export("init")]
		public Weather() : base(NSObjectFlag.Empty) {
			InitializeHandle(Messaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("init")), "init");
		}

		public Weather(IntPtr handle) : base(handle) {
		}

		public virtual Double CurrentTemperature {
			[Export("currentTemperature")]
			get {
				return Messaging.Double_objc_msgSend(this.Handle, Selector.GetHandle("currentTemperature"));
			}

			[Export("setCurrentTemperature:")]
			set {
				Messaging.void_objc_msgSend_Double(this.Handle, Selector.GetHandle("setCurrentTemperature:"), value);
			}
		}

	}
}
