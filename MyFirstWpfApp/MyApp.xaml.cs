using System;
using System.Windows;

namespace MyFirstWpfApp
{
	public partial class MyApp : Application
	{
		void AppStartup(object sender, StartupEventArgs e)
		{
			Window window = new Window1();
			window.Show();
		}
	}
}