using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WindowScrape.Types;
using WindowScrape.Static;
using howto_list_desktop_windows;

namespace windowSwaper_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static HotKey hotkey; 

        private static List<IntPtr> handles;
        private static List<string> titles;
        
        private static HwndObject window_1;
        private static HwndObject window_2;

        private static System.Drawing.Point window_1_location;
        private static System.Drawing.Point window_2_location;


        public App()
        {
            hotkey = new HotKey(System.Windows.Input.Key.K, KeyModifier.Ctrl, OnHotKeyHandler);
            DesktopWindowsStuff.windowTitleToExclude = "MainWindow"; //add title of the main window to be excluded when list of open widows is fetch
        }


        public static String getDebugString()
        {
            return window_1.Location.ToString() + " " + window_2.Location.ToString();
        }

        private static void OnHotKeyHandler(HotKey obj)
        {
            //thing that happen after hotkey is pressed

            DesktopWindowsStuff.GetDesktopWindowHandlesAndTitles(out handles, out titles);
            Debug.Print(titles[0] + " | " + titles[1]);

            window_1 = new HwndObject(handles[0]);
            window_2 = new HwndObject(handles[1]);


            window_1_location = window_1.Location;
            window_2_location = window_2.Location;

            window_1.Location = window_2_location;
            window_2.Location = window_1_location;
            

        }

    }
}
