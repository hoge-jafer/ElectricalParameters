﻿#pragma checksum "D:\Code\ElectricalParameters\ElectricalParameters\FindViews\Hardware.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7AACE9857B6B9BA6092B50F27F192934"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectricalParameters.FindViews
{
    partial class Hardware : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class Hardware_obj14_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHardware_Bindings
        {
            private global::ElectricalParameters.Models.FindHardware dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;

            public Hardware_obj14_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 15:
                        this.obj15 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 16:
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::ElectricalParameters.Models.FindHardware data = args.NewValue as global::ElectricalParameters.Models.FindHardware;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::ElectricalParameters.Models.FindHardware was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::ElectricalParameters.Models.FindHardware);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::ElectricalParameters.Models.FindHardware) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IHardware_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Hardware_obj14_Bindings

            public void SetDataRoot(global::ElectricalParameters.Models.FindHardware newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ElectricalParameters.Models.FindHardware obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_HardwareImage(obj.HardwareImage, phase);
                        this.Update_HardwareName(obj.HardwareName, phase);
                    }
                }
            }
            private void Update_HardwareImage(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj15, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_HardwareName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                }
            }
        }

        private class Hardware_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHardware_Bindings
        {
            private global::ElectricalParameters.FindViews.Hardware dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj2;

            public Hardware_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IHardware_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // Hardware_obj1_Bindings

            public void SetDataRoot(global::ElectricalParameters.FindViews.Hardware newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ElectricalParameters.FindViews.Hardware obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FindHardwares(obj.FindHardwares, phase);
                    }
                }
            }
            private void Update_FindHardwares(global::System.Collections.ObjectModel.ObservableCollection<global::ElectricalParameters.Models.FindHardware> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.HardwareGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 79 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.HardwareGridView).ItemClick += this.HardwareGridView_ItemClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.HardwareSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4:
                {
                    this.ColorfulButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 104 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ColorfulButton).Click += this.ColorfulButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.GALAXYTechnologyButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 107 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GALAXYTechnologyButton).Click += this.GALAXYTechnologyButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.ZotacButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 110 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ZotacButton).Click += this.ZotacButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.MSIButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 113 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MSIButton).Click += this.MSIButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.SapphiretechButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 116 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SapphiretechButton).Click += this.SapphiretechButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.GIGABYTEButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 119 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GIGABYTEButton).Click += this.GIGABYTEButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.ASUSButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 122 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ASUSButton).Click += this.ASUSButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.COLORFIREButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 125 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.COLORFIREButton).Click += this.COLORFIREButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.MaxsunButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 128 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MaxsunButton).Click += this.MaxsunButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.GainwardButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 131 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GainwardButton).Click += this.GainwardButton_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.HardwareNameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.GraphicsChipTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.CoreFrequencyTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.MemoryFrequencyTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.VideoMemoryTypeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.AvailableMemoryTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 23:
                {
                    this.ResTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24:
                {
                    this.FindHardwareListAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 143 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.FindHardwareListAppBarButton).Click += this.FindHardwareListAppBarButton_Click;
                    #line default
                }
                break;
            case 25:
                {
                    this.H0meAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 149 "..\..\..\FindViews\Hardware.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.H0meAppBarButton).Click += this.H0meAppBarButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Hardware_obj1_Bindings bindings = new Hardware_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 14:
                {
                    global::Windows.UI.Xaml.Controls.Grid element14 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Hardware_obj14_Bindings bindings = new Hardware_obj14_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::ElectricalParameters.Models.FindHardware) element14.DataContext);
                    element14.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element14, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

