// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Okta.Xamarin.iOS.ExampleApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView configTestView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton loginBtn { get; set; }

        [Action ("LoginBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LoginBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (configTestView != null) {
                configTestView.Dispose ();
                configTestView = null;
            }

            if (loginBtn != null) {
                loginBtn.Dispose ();
                loginBtn = null;
            }
        }
    }
}