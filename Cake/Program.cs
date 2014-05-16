using System;
#if PLATFORM_WINDOWS

#elif PLATFORM_MACOS
using MonoMac.AppKit;
using MonoMac.Foundation;
#elif PLATFORM_IOS
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif


namespace Cake
{

#if PLATFORM_WINDOWS
    public class Program
    {
        public static void Main(string[] args)
        {
            using (CakeGame game = new CakeGame())
            {
                game.Run();
            }
        }
    }
#elif PLATFORM_MACOS
	static class Program
	{
		static void Main (string[] args)
		{
			NSApplication.Init ();

			using (var p = new NSAutoreleasePool ()) {
				NSApplication.SharedApplication.Delegate = new AppDelegate ();
				NSApplication.Main (args);
			}
		}
	}

	class AppDelegate : NSApplicationDelegate
	{
		CakeGame game;

		public override void FinishedLaunching (MonoMac.Foundation.NSObject notification)
		{
			game = new CakeGame ();
			game.Run ();
		}

		public override bool ApplicationShouldTerminateAfterLastWindowClosed (NSApplication sender)
		{
			return true;
		}
	}
#elif PLATFORM_IOS
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
#endif

}
