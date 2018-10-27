using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TopLevelWindowsExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Content1.Text = Application.Current.MainWindow.ToString();
            // Application object's 'Windows' property contais list of all top level Windows.
            //var windows = Application.Current.Windows;
            WindowMenu.SubmenuOpened += WindowMenu_SubmenuOpened;
        }

        // To populate the Windows menu
        private void WindowMenu_SubmenuOpened(object sender, RoutedEventArgs e)
        {
            WindowMenu.Items.Clear();
            foreach (Window window in Application.Current.Windows)
            {
                MenuItem item = new MenuItem();
                item.Header = window.Title;
                item.Click += windowMenuItem_Click;
                item.Tag = window;
                item.IsChecked = window.IsActive;
                WindowMenu.Items.Add(item);
            }
        }

        private void windowMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window window = (Window)((MenuItem)sender).Tag;
            window.Activate();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window();
            window.Title = "New Window";
            window.Show();
        }
    }
}
