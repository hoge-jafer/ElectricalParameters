using ElectricalParameters.FindViews;
using ElectricalParameters.MainViews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ElectricalParameters
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //private void FindAppBarButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(typeof(Find));
        //}

        //private void ListAppBarButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MenuSpliview.IsPaneOpen = !MenuSpliview.IsPaneOpen;           
        //}

        //private void MenuFindButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //Frame.Navigate(typeof(Find));
        //    Frame.Navigate(typeof(Phone));
        //}

        private void MenuFindPhoneButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Phone));
        }

        private void ComputerButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Computer));
        }

        private void HardwareButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hardware));
        }

        private void DigitalAudioButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Digital));
        }

        //private void MenuListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (AboutListBoxItem.IsSelected)
        //    {
        //        Frame.Navigate(typeof(About));
        //    }
        //}

        private void HotAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
    }
}
