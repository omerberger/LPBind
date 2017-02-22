using System;
using UIKit;
using LibTester;
using System.Drawing;

namespace App
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
			this.addLiveEngageButton();
		}

		void addLiveEngageButton()
		{
			UIButton btn = new UIButton(UIButtonType.RoundedRect);
			btn.SetTitle("Connect To LiveEngage", UIControlState.Normal);
			btn.Frame = new RectangleF(0, 0, 250, 100);
			btn.Center = this.View.Center;
			btn.TouchUpInside += (sender, e) =>
			{
				Console.WriteLine("button action");

				LEStaticLib ls = new LEStaticLib();
				ls.SomeString = "sd";
				Console.WriteLine(ls.SomeString);

				string str = 	ls.TextFromSDK;
				Console.WriteLine(str);

				string staticStr = LEStaticLib.StaticTextFromSDK;
				Console.WriteLine(staticStr);

				ls.InitiateSDK();
				ls.ShowConversation();

			};

			this.View.AddSubview(btn);
		}


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
