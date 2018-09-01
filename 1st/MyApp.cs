using System;
using System.Windows; // The root WPF namespace.

namespace MyFirstWpfApp
{
	class MyApp : Application
	{
		/*******************************************************************************
		* STAThread attribute signals .net to make sure that when COM is initilized
		* on the application's main thread, it's initialized to be compatible with
		* single threaded UI work, as required by the WPF applications.
		*******************************************************************************/
		[STAThread]
		static void Main()
		{
			MyApp app = new MyApp();
			app.Startup += app.AppStartup;
			app.Run();
		}
		
		void AppStartup(object sender, StartupEventArgs e)
		{
			// By default, when all top level windows are
			// closed, the app shuts down
			Window window = new Window();
			window.Title = "Hello, WPF";
			window.Show();
		}
	}
}