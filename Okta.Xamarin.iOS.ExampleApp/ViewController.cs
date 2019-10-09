using Foundation;
using System;
using UIKit;

namespace Okta.Xamarin.iOS.ExampleApp
{
	public partial class ViewController : UIViewController
	{

		OidcClient client;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			OktaConfig config = OktaConfig.LoadFromPList("OktaConfig.plist");
			this.configTestView.Text = $"Domain: {config.OktaDomain}\n" +
				$"ClientId: {config.ClientId}\n" +
				$"RedirectUri: {config.RedirectUri}\n" +
				$"PostLogoutRedirecturi: {config.PostLogoutRedirectUri}\n" +
				$"Scope: {string.Join(", ", config.Scopes)}\n" +
				$"ClockSkew: {config.ClockSkew.ToString()}\n";

			client = new OidcClient(this, config);

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		async partial void LoginBtn_TouchUpInside(UIButton sender)
		{
			var res = await client.SignInWithBrowserAsync();

			this.configTestView.Text = $"AccessToken: {res.AccessToken}\n" +
				$"IdToken: {res.IdToken}\n" +
				$"Expires: {res.Expires}\n" +
				$"Scope: {res.Scope}\n" +
				$"RefreshToken: {res.RefreshToken ?? "<none>"}\n" +
				$"TokenType: {res.TokenType}\n";

			res.AccessToken.Clone();
		}
	}
}