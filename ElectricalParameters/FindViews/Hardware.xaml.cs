using ElectricalParameters.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ElectricalParameters.FindViews
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Hardware : Page
    {
        public ObservableCollection<FindHardware> FindHardwares;
        public Hardware()
        {
            this.InitializeComponent();
            FindHardwares = new ObservableCollection<FindHardware>();
        }

        private void H0meAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("asus", FindHardwares);
        }

        private void FindHardwareListAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void HardwareGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var hardware =(FindHardware)e.ClickedItem;
            HardwareNameTextBlock.Text = hardware.HardwareName;
            GraphicsChipTextBlock.Text = hardware.GraphicsChip;
            CoreFrequencyTextBlock.Text = hardware.CoreFrequency+"MHz";
            MemoryFrequencyTextBlock.Text = hardware.MemoryFrequency+"GHz";
            AvailableMemoryTextBlock.Text = hardware.AvailableMemory+"MB";
            VideoMemoryTypeTextBlock.Text = "GDDR"+hardware.VideoMemoryType;
            ResTextBlock.Text = hardware.Res;
        }

        private void ColorfulButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("colorful", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void GALAXYTechnologyButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("galaxytechnology", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void ZotacButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("zotac", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void MSIButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("msi", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void SapphiretechButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("sapphiretech", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void GIGABYTEButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("gigabyte", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void ASUSButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("asus", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void MaxsunButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("maxsun", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void GainwardButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("gainward", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }

        private void COLORFIREButton_Click(object sender, RoutedEventArgs e)
        {
            FindHardwareManager.GetHardware("colorfire", FindHardwares);
            HardwareSplitView.IsPaneOpen = !HardwareSplitView.IsPaneOpen;
        }
    }
}
