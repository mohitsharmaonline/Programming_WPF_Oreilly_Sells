using System;
using System.Windows;
using System.Windows.Controls;	// Button et al

namespace MyFirstWpfApp
{
	class Window1 : Window
	{
		public Window1()
		{
			this.Title = "Hello, WPF";
			
			// Do something interesting
			Button button = new Button();
			button.Content = "Click me, baby, one more time!";
			button.Width = 200;
			button.Height = 25;
			button.Click += button_Click;
			
			this.Content = button;
		}
		
		void button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("You've done that before, haven't you...", "Nice!");
		}
	}
}