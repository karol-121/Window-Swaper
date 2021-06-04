using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using Forms = System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace windowSwaper_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.Hide(); this allows the program to start without the window being open, can be usefull when the application will autorun on startup
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            debugString.Text = App.getDebugString();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            debugString.Text = e.Key.ToString();
        }

        private void MyWindow_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
            {
                Hide();
            } 
        }
    }
}
