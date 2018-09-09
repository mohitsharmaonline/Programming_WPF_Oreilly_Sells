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
			// Let the Window1 initialize itself
			Window window = new Window1();
			window.Show();
		}
	}
}