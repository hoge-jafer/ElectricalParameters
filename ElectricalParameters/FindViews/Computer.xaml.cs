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
    public sealed partial class Computer : Page
    {
        public ObservableCollection<FindComputer> FindComputers;
        public Computer()
        {
            this.InitializeComponent();
            FindComputers = new ObservableCollection<FindComputer>();
        }

        private void H0meAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("microsoft", FindComputers);
        }

        private void FindComputerListAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void ComputerGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var computer = (FindComputer)e.ClickedItem;
            ComputerNameTextBlock.Text = computer.ComputerName;
            SystemTextBlock.Text = "预装"+computer.System;
            CPUTypeTextBlock.Text = computer.CPUType;
            FrequencyTextBlock.Text = computer.Frequency + "GHz";
            RamTextBlock.Text = computer.Ram + "GB";
            RamTypeTextBlock.Text = "DDR"+computer.RamType;
            SizeTextBlock.Text = computer.Size + "英寸";
            ResTextBlock.Text = computer.Res;
            HardCapacityTextBlock.Text = computer.HardCapacity;
            GraphicsTextBlock.Text = computer.Graphics;
            GraphicsRamTextBlock.Text = computer.GraphicsRam + "GB";
            GraphicsTypeTextBlock.Text = "GDDR"+computer.GraphicsType;
        }

        private void MicrosoftButtton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("microsoft", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void AppleButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("apple", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void HPButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("hp", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void DELLButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("dell", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void ASUSButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("asus", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void HaSeeButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("hasee", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void ThinkPadButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("thinkpad", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void ACERButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("acer", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void ThunderobotButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("thunderobot", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void AlienwareButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("alienware", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void MACHENIKEButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("machenike", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void MSIButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("msi", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void SAMSUNGButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("samsung", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void RazerButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("razer", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void TOSHIBAButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("toshiba", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void GIGABYTEButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("gigabyte", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void TerransForceButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("terransforce", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void LenovoButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("lenovo", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void MiButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("mi", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void SAMSUNGTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("samsungtable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void RamosTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("ramostable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void TeclastTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("teclasttable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void AcerTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("acertable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void HPTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("hptable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void ThinkPadTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("thinkpadtable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void VidoTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("vidotable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void NokiaTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("nokiatable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void CubeTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("cubetable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void MicrosoftTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("microsofttable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void MiTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("mitable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }

        private void AppleTableButton_Click(object sender, RoutedEventArgs e)
        {
            FindComputerManager.GetComputer("appletable", FindComputers);
            ComputerSplitView.IsPaneOpen = !ComputerSplitView.IsPaneOpen;
        }
    }
}
