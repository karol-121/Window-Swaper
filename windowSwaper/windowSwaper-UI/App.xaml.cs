using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WindowScrape.Types;
using WindowScrape.Static;

namespace windowSwaper_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static HotKey hotkey = new HotKey(System.Windows.Input.Key.K, KeyModifier.Ctrl, OnHotKeyHandler);
        
        private static HwndObject hwndObject;

        private static System.Drawing.Point windowLocation = new System.Drawing.Point(50 , 50);


        public App()
        {
            hwndObject = new HwndObject(HwndInterface.GetHwndFromTitle("Discord"));
            
        }

        public static String getShortcut()
        {

            return hotkey.KeyModifiers.ToString() + " + " + hotkey.Key.ToString();
        }

        private static void OnHotKeyHandler(HotKey obj)
        {
            //thing that happen after hotkey is pressed
            hwndObject.Location = windowLocation;

        }

    }
}
