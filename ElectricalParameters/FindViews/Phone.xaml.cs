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
    public sealed partial class Phone : Page
    {
        //public List<FindPhone> findPhones;
        public ObservableCollection<FindPhone> FindPhones;
        public Phone()
        {
            this.InitializeComponent();
            FindPhones = new ObservableCollection<FindPhone>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("nokia", FindPhones);
        }

        private void AppleButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("iphone", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void SaSumg_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("sanxing", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void PhoneGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var phone =(FindPhone)e.ClickedItem;
            ScreenSizeTextBlock.Text =phone.ScreenSize+"英寸";
            ScreenMaterialTextBlock.Text = phone.ScreenMaterial;
            OtherScreenParameterTextBlock.Text = phone.OtherScreenParameter;
            ScreenProportionTextBlock.Text = phone.ScreenProportion + "%";
            NetWorkTypeTextBlock.Text = phone.NetWorkType;
            OperatingSystemTextBlock.Text = phone.OperatingSystem;
            ResTextBlock.Text =phone.Res+"像素";
            RearCameraTextBlock.Text =phone.RearCamera+"万像素";
            FrontFacingCameraTextBlock.Text =phone.FrontFacingCamera+"万像素";
            THTextBlock.Text = phone.TH;
            SensorsTextBlock.Text = phone.Sensors;
            PhoneColorTextBlock.Text = phone.PhoneColor;
            PhoneLampTextBlock.Text = phone.PhoneLamp+"补光灯";
            PhoneCPUTextBlock.Text = phone.PhoneCPU;
            PhoneCPUFrequencyTextBlock.Text =phone.PhoneCPUFrequency+"GHz";
            PhoneROMTextBlock.Text = phone.PhoneROM;
            MemoryTextBlock.Text =phone.Memory+"GB";
            BatteryCapacityTextBlock.Text =phone.BatteryCapacity+"mAh";
            CoresTextBlock.Text =phone.Cores+"核";
            BatteryTypeTextBolck.Text =phone.BatteryType+"拆卸时电池";
        }

        private void PhoneListAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void HomeAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void NokiaButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("nokia", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void MicrosoftButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("microsoft", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void MotorolaButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("motorola", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void BlockBerryButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("blackberry", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void HTCButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("htc", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void HUAWEIButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("huawei", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void OnePlusButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("oneplus", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void SONYButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("sony", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void SmartisanButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("smartisan", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void OPPOButon_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("oppo", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void MiButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("mi", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void HonorButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("honor", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void LGButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("lg", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void TCLButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("tcl", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void LetvButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("letv", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void VivoButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("vivo", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void ZTEButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("zte", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void ZUKButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("zuk", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void QIHUButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("360", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void NubiaButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("nubia", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void GioneeButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("gionee", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void LenovoButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("lenovo", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }

        private void MeiZuButton_Click(object sender, RoutedEventArgs e)
        {
            FindPhoneManager.GetPhone("meizu", FindPhones);
            PhoneSplitView.IsPaneOpen = !PhoneSplitView.IsPaneOpen;
        }
    }
}
