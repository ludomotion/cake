﻿using System;
using Cake;
using MonoMac.AppKit;
using MonoMac.Foundation;

namespace Cake
{
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
}