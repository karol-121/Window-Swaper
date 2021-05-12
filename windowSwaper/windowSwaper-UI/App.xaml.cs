using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace windowSwaper_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly HotKey hotkey = new HotKey(System.Windows.Input.Key.S, KeyModifier.Ctrl, OnHotKeyHandler);
        private static int hotkeyDetections = 0;

        public static int getHotkeyDetections()
        {
            return hotkeyDetections;
        }


        private static void OnHotKeyHandler(HotKey obj)
        {
            //thing that happen after hotkey is pressed

            hotkeyDetections++;
            MessageBox.Show("hello");
            
        }

    }
}
