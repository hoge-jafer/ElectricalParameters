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
    public sealed partial class Digital : Page
    {
        public ObservableCollection<FindDigital> FindDigitals;
        public Digital()
        {
            this.InitializeComponent();
            FindDigitals = new ObservableCollection<FindDigital>();
        }

        private void H0meAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("sony", FindDigitals);
        }

        private void DigitalAudioListAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void DigitalGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var digital =(FindDigital)e.ClickedItem;
            DigitalNameTextBlock.Text = digital.DigitalName;
            EffectivePixelsTextBlock.Text = digital.EffectivePixels+"万";
            OpticalZoomTextBlock.Text = digital.OpticalZoom+"倍";
            DigitalZoomTextBlock.Text = digital.DigitalZoom+"倍";
            ResTextBlock.Text = digital.Res;
            LensTypeTextBlock.Text = digital.LensType;
        }

        private void CanonButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("canon", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void NikonButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("nikon", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void SONYButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("sony", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void CASIOButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("casio", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void KodakButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("kodak", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void LeicaButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("leica", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void FUJIFILMButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("fujifilm", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void PENTAXButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("pentax", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }

        private void SAMSUNGButton_Click(object sender, RoutedEventArgs e)
        {
            FindDigitalManager.GetDigital("samsung", FindDigitals);
            DigitalSplitView.IsPaneOpen = !DigitalSplitView.IsPaneOpen;
        }
    }
}
