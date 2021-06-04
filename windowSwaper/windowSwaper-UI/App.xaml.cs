using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using WindowScrape.Types;
using Forms = System.Windows.Forms;

namespace windowSwaper_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly int horisontalResolution = 1920;

        private readonly Forms.NotifyIcon notifyIcon;

        private static List<HwndObject> windows;

        private static HwndObject window_1;
        private static HwndObject window_2;

        private static System.Drawing.Point window_1_location;
        private static System.Drawing.Point window_2_location;


        public App()
        {
            notifyIcon = new Forms.NotifyIcon();
            notifyIcon.Icon = new Icon("resources/icon-16.ico");
            notifyIcon.Text = "Window Swapper";
            notifyIcon.Click += NotifyIcon_Click;
            notifyIcon.Visible = true;

            new HotKey(System.Windows.Input.Key.Oem8, KeyModifier.Win, OnHotKeyHandler);
        }


        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            MainWindow.Show();
            MainWindow.WindowState = WindowState.Normal;
            MainWindow.Activate();
            
        }

        protected override void OnExit(ExitEventArgs e)
        {
            notifyIcon.Dispose();
            base.OnExit(e);
        }

        public static String getDebugString()
        {
            return "hello";
        }

        private void OnHotKeyHandler(HotKey obj)
        {
            //thing that happen after hotkey is pressed

            if (MainWindow.WindowState == WindowState.Minimized) //only swap windows, when ui window is minimized
            {
                //get list of the two most top desktop windows, these will be the ones to be swapped
                windows = HwndObject.GetTwoMostTopDesktopWindows();

                //get windows to swap, swap only the main with the second main
                window_1 = windows[0];
                window_2 = windows[1];

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
            else
            {
                //print message to user that the swap is disable when window is on
            }

            
        }
    }
}
