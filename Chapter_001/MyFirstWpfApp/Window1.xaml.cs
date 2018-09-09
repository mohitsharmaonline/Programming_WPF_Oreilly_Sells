using System;
using System.Windows;
using System.Windows.Controls;

namespace MyFirstWpfApp
{
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		
		void button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("You've done that before, haven't you...", "Nice!");
		}
	}
}