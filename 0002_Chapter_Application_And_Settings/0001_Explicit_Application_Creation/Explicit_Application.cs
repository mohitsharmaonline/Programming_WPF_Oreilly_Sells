class Program
{
	[STAThread]
	static void Main()
	{
		Application app = new System.Windows.Application();
		// While the application is running WPF processes Windows messages and routes events to WPF UI object
		// as necessary.
		Window1 window = new Window1();
		window.Show();
		app.Run();
		// once an instance of Application object is created, it is available via the Current static
		// property of the Application class.
		// WPF makes sure that at most one Application object is created per Application Domain.
		
	}
	
}
