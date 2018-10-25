
using System.Windows;

namespace DAtaBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NickNames names;
        public MainWindow()
        {
            InitializeComponent();

            this.addButton.Click += AddButton_Click;

            this.names = (NickNames)this.FindResource("names");

            //// Make data available for binding
            //dockPanel.DataContext = this.names;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.names.Add(new NickName(name: textBoxName.Text, nick: textBoxNick.Text));
        }
    }
}
