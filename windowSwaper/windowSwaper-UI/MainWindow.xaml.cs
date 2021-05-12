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

namespace windowSwaper_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        public static RoutedCommand MyCommand = new RoutedCommand();
        private static int shortcutUses = 0;



        public MainWindow()
        {
            InitializeComponent();
            MyCommand.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
        }

        public void MyCommandExecuted(object sender, ExecutedRoutedEventArgs e) 
        {
            shortcutUses++;
            shortcutUseDebug.Text = shortcutUses.ToString();
        }
    }
}
