// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmXSample.iOS
{
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UIButton LoginBtn { get; set; }

		[Outlet]
		UIKit.UIView LoginView { get; set; }

		[Outlet]
		UIKit.UIView OuterView { get; set; }

		[Outlet]
		UIKit.UITextField Pass { get; set; }

		[Outlet]
		UIKit.UITextField UName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LoginBtn != null) {
				LoginBtn.Dispose ();
				LoginBtn = null;
			}

			if (OuterView != null) {
				OuterView.Dispose ();
				OuterView = null;
			}

			if (Pass != null) {
				Pass.Dispose ();
				Pass = null;
			}

			if (UName != null) {
				UName.Dispose ();
				UName = null;
			}

			if (LoginView != null) {
				LoginView.Dispose ();
				LoginView = null;
			}
		}
	}
}
