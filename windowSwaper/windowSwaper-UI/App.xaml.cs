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
        private static int horisontalResolution = 1920;

        private static List<IntPtr> handles;
        private static List<string> titles;
        
        private static HwndObject window_1;
        private static HwndObject window_2;

        private static System.Drawing.Point window_1_location;
        private static System.Drawing.Point window_2_location;


        public App()
        {
            hotkey = new HotKey(System.Windows.Input.Key.Oem8, KeyModifier.Win, OnHotKeyHandler);
            DesktopWindowsStuff.windowTitleToExclude = "MainWindow"; //add title of the main window to be excluded when list of open widows is fetch
        }


        public static String getDebugString()
        {
            return hotkey.Key.ToString();
        }

        private static void OnHotKeyHandler(HotKey obj)
        {
            //thing that happen after hotkey is pressed

            //get list of active windows and their titles (titles will not be needed, but are required for this function to work)
            DesktopWindowsStuff.GetDesktopWindowHandlesAndTitles(out handles, out titles);

            //get windows to swap, swap only the main with the second main
            window_1 = new HwndObject(handles[0]);
            window_2 = new HwndObject(handles[1]);

            //get current locations of the windows
            window_1_location = window_1.Location;
            window_2_location = window_2.Location;

            if (window_1.Location.X < 0 && window_2.Location.X > 0) //the main window is to the left and second main window is to the right 
            {
                //move main window to the right
                window_1_location.X += horisontalResolution; //modify the point variable to new location
                window_1.Location = window_1_location; //assign the modified location variable as main window location

                //move second main window to the left
                window_2_location.X -= horisontalResolution; //modify the point variable to new location
                window_2.Location = window_2_location; //assign the modified location variable as main window location
            }
            else if (window_1.Location.X > 0 && window_2.Location.X < 0) //the main window is to the right and second main window is to the left
            {
                //move main window to the left
                window_1_location.X -= horisontalResolution; //modify the point variable to new location
                window_1.Location = window_1_location; //assign the modified location variable as main window location

                //move second main window to the right
                window_2_location.X += horisontalResolution; //modify the point variable to new location
                window_2.Location = window_2_location; //assign the modified location variable as main window location

            }

        
            

        }

    }
}
