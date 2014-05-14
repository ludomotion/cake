
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Cake {
	[Register ("AppDelegate")]
	class Program : UIApplicationDelegate
	{
		CakeGame game;

		public override void FinishedLaunching (UIApplication app)
		{
			game = new CakeGame ();
			game.Run ();
		}

		static void Main (string[] args)
		{
			UIApplication.Main (args, "UIApplication", "AppDelegate");
		}
	}
}