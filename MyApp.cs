using System;
using System.Windows; // The root WPF namespace.

namespace MyFirstWpfApp
{
	class MyApp
	{
		/*******************************************************************************
		* STAThread attribute signals .net to make sure that when COM is initilized
		* on the application's main thread, it's initialized to be compatible with
		* single threaded UI work, as required by the WPF applications.
		*******************************************************************************/
		[STAThread]
		static void Main()
		{
			// The WPF message box
			MessageBox.Show("Hello, WPF");  // it's actually an interop call to Win32
			// Proceed to rtf dicument named MyApp to see how it gets compiled.
		}
	}
}