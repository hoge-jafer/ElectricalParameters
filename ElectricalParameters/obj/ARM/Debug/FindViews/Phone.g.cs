﻿#pragma checksum "D:\Code\ElectricalParameters\ElectricalParameters\FindViews\Phone.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "209144CA36946DBB39673075AFE2F293"
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
    partial class Phone : 
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

        private class Phone_obj30_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPhone_Bindings
        {
            private global::ElectricalParameters.Models.FindPhone dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj31;
            private global::Windows.UI.Xaml.Controls.TextBlock obj32;

            public Phone_obj30_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 31:
                        this.obj31 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 32:
                        this.obj32 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::ElectricalParameters.Models.FindPhone data = args.NewValue as global::ElectricalParameters.Models.FindPhone;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::ElectricalParameters.Models.FindPhone was expected.");
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
                        this.SetDataRoot(args.Item as global::ElectricalParameters.Models.FindPhone);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::ElectricalParameters.Models.FindPhone) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IPhone_Bindings

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

            // Phone_obj30_Bindings

            public void SetDataRoot(global::ElectricalParameters.Models.FindPhone newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ElectricalParameters.Models.FindPhone obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_PhoneImage(obj.PhoneImage, phase);
                        this.Update_PhoneName(obj.PhoneName, phase);
                    }
                }
            }
            private void Update_PhoneImage(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj31, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_PhoneName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj32, obj, null);
                }
            }
        }

        private class Phone_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPhone_Bindings
        {
            private global::ElectricalParameters.FindViews.Phone dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj2;

            public Phone_obj1_Bindings()
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

            // IPhone_Bindings

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

            // Phone_obj1_Bindings

            public void SetDataRoot(global::ElectricalParameters.FindViews.Phone newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ElectricalParameters.FindViews.Phone obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FindPhones(obj.FindPhones, phase);
                    }
                }
            }
            private void Update_FindPhones(global::System.Collections.ObjectModel.ObservableCollection<global::ElectricalParameters.Models.FindPhone> obj, int phase)
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
                    #line 9 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.PhoneGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 171 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.PhoneGridView).ItemClick += this.PhoneGridView_ItemClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.PhoneSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4:
                {
                    this.PhoneCategoryGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 5:
                {
                    this.AppleButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 201 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AppleButton).Click += this.AppleButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.SaSumg = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 207 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaSumg).Click += this.SaSumg_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.NokiaButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 213 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.NokiaButton).Click += this.NokiaButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.MicrosoftButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 217 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MicrosoftButton).Click += this.MicrosoftButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.MotorolaButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 222 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MotorolaButton).Click += this.MotorolaButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.BlockBerryButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 227 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BlockBerryButton).Click += this.BlockBerryButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.HUAWEIButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 232 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HUAWEIButton).Click += this.HUAWEIButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.HTCButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 237 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HTCButton).Click += this.HTCButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.MeiZuButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 242 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MeiZuButton).Click += this.MeiZuButton_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.LenovoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 247 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LenovoButton).Click += this.LenovoButton_Click;
                    #line default
                }
                break;
            case 15:
                {
                    this.OnePlusButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 252 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.OnePlusButton).Click += this.OnePlusButton_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.SONYButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 257 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SONYButton).Click += this.SONYButton_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.OPPOButon = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 261 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.OPPOButon).Click += this.OPPOButon_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.MiButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 266 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MiButton).Click += this.MiButton_Click;
                    #line default
                }
                break;
            case 19:
                {
                    this.HonorButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 270 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HonorButton).Click += this.HonorButton_Click;
                    #line default
                }
                break;
            case 20:
                {
                    this.LGButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 274 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LGButton).Click += this.LGButton_Click;
                    #line default
                }
                break;
            case 21:
                {
                    this.TCLButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 278 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.TCLButton).Click += this.TCLButton_Click;
                    #line default
                }
                break;
            case 22:
                {
                    this.LetvButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 282 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LetvButton).Click += this.LetvButton_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.VivoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 286 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.VivoButton).Click += this.VivoButton_Click;
                    #line default
                }
                break;
            case 24:
                {
                    this.SmartisanButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 291 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SmartisanButton).Click += this.SmartisanButton_Click;
                    #line default
                }
                break;
            case 25:
                {
                    this.ZTEButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 295 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ZTEButton).Click += this.ZTEButton_Click;
                    #line default
                }
                break;
            case 26:
                {
                    this.ZUKButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 299 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ZUKButton).Click += this.ZUKButton_Click;
                    #line default
                }
                break;
            case 27:
                {
                    this.QIHUButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 303 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.QIHUButton).Click += this.QIHUButton_Click;
                    #line default
                }
                break;
            case 28:
                {
                    this.NubiaButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 307 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.NubiaButton).Click += this.NubiaButton_Click;
                    #line default
                }
                break;
            case 29:
                {
                    this.GioneeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 311 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GioneeButton).Click += this.GioneeButton_Click;
                    #line default
                }
                break;
            case 33:
                {
                    this.ScreenSizeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 34:
                {
                    this.ResTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 35:
                {
                    this.ScreenMaterialTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 36:
                {
                    this.OtherScreenParameterTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 37:
                {
                    this.ScreenProportionTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 38:
                {
                    this.NetWorkTypeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39:
                {
                    this.OperatingSystemTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 40:
                {
                    this.RearCameraTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41:
                {
                    this.FrontFacingCameraTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 42:
                {
                    this.THTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 43:
                {
                    this.SensorsTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 44:
                {
                    this.MemoryTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 45:
                {
                    this.PhoneColorTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 46:
                {
                    this.PhoneLampTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 47:
                {
                    this.CoresTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 48:
                {
                    this.PhoneCPUTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 49:
                {
                    this.PhoneCPUFrequencyTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 50:
                {
                    this.PhoneROMTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 51:
                {
                    this.BatteryCapacityTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 52:
                {
                    this.BatteryTypeTextBolck = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 53:
                {
                    this.PhoneListAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 325 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PhoneListAppBarButton).Click += this.PhoneListAppBarButton_Click;
                    #line default
                }
                break;
            case 54:
                {
                    this.HomeAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 329 "..\..\..\FindViews\Phone.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.HomeAppBarButton).Click += this.HomeAppBarButton_Click;
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
                    Phone_obj1_Bindings bindings = new Phone_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 30:
                {
                    global::Windows.UI.Xaml.Controls.Grid element30 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Phone_obj30_Bindings bindings = new Phone_obj30_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::ElectricalParameters.Models.FindPhone) element30.DataContext);
                    element30.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element30, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

