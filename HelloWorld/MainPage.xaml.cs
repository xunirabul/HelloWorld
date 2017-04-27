using System.Windows;
using System.Windows.Controls;

namespace HelloWorld
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtText.Text = txtInput.Text; // comment add rrr
            // branch master
            // hello new branch
            // remote
	    // remote333
        }
    }
}
