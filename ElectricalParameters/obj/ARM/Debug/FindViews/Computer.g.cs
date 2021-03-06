﻿#pragma checksum "D:\Code\ElectricalParameters\ElectricalParameters\FindViews\Computer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1E10C1550A63394B3F473E8FE59988A4"
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
    partial class Computer : 
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

        private class Computer_obj33_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IComputer_Bindings
        {
            private global::ElectricalParameters.Models.FindComputer dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj34;
            private global::Windows.UI.Xaml.Controls.TextBlock obj35;

            public Computer_obj33_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 34:
                        this.obj34 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 35:
                        this.obj35 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::ElectricalParameters.Models.FindComputer data = args.NewValue as global::ElectricalParameters.Models.FindComputer;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::ElectricalParameters.Models.FindComputer was expected.");
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
                        this.SetDataRoot(args.Item as global::ElectricalParameters.Models.FindComputer);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::ElectricalParameters.Models.FindComputer) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IComputer_Bindings

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

            // Computer_obj33_Bindings

            public void SetDataRoot(global::ElectricalParameters.Models.FindComputer newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ElectricalParameters.Models.FindComputer obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ComputerImage(obj.ComputerImage, phase);
                        this.Update_ComputerName(obj.ComputerName, phase);
                    }
                }
            }
            private void Update_ComputerImage(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj34, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_ComputerName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj35, obj, null);
                }
            }
        }

        private class Computer_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IComputer_Bindings
        {
            private global::ElectricalParameters.FindViews.Computer dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj2;

            public Computer_obj1_Bindings()
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

            // IComputer_Bindings

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

            // Computer_obj1_Bindings

            public void SetDataRoot(global::ElectricalParameters.FindViews.Computer newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ElectricalParameters.FindViews.Computer obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FindComputers(obj.FindComputers, phase);
                    }
                }
            }
            private void Update_FindComputers(global::System.Collections.ObjectModel.ObservableCollection<global::ElectricalParameters.Models.FindComputer> obj, int phase)
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
                    #line 8 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.ComputerGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 113 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.ComputerGridView).ItemClick += this.ComputerGridView_ItemClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.ComputerSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4:
                {
                    this.MicrosoftTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 218 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MicrosoftTableButton).Click += this.MicrosoftTableButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.SAMSUNGTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 222 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SAMSUNGTableButton).Click += this.SAMSUNGTableButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.AppleTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 226 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AppleTableButton).Click += this.AppleTableButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.RamosTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 229 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RamosTableButton).Click += this.RamosTableButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.TeclastTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 233 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.TeclastTableButton).Click += this.TeclastTableButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.AcerTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 237 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AcerTableButton).Click += this.AcerTableButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.ThinkPadTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 241 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ThinkPadTableButton).Click += this.ThinkPadTableButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.NokiaTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 245 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.NokiaTableButton).Click += this.NokiaTableButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.MiTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 249 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MiTableButton).Click += this.MiTableButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.CubeTableButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 252 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.CubeTableButton).Click += this.CubeTableButton_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.MicrosoftButtton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 138 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MicrosoftButtton).Click += this.MicrosoftButtton_Click;
                    #line default
                }
                break;
            case 15:
                {
                    this.AppleButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 142 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AppleButton).Click += this.AppleButton_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.HPButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 146 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HPButton).Click += this.HPButton_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.DELLButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 150 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DELLButton).Click += this.DELLButton_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.ASUSButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 154 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ASUSButton).Click += this.ASUSButton_Click;
                    #line default
                }
                break;
            case 19:
                {
                    this.HaSeeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 158 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HaSeeButton).Click += this.HaSeeButton_Click;
                    #line default
                }
                break;
            case 20:
                {
                    this.ThinkPadButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 162 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ThinkPadButton).Click += this.ThinkPadButton_Click;
                    #line default
                }
                break;
            case 21:
                {
                    this.ACERButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 166 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ACERButton).Click += this.ACERButton_Click;
                    #line default
                }
                break;
            case 22:
                {
                    this.ThunderobotButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 170 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.ThunderobotButton).Click += this.ThunderobotButton_Click;
                    #line default
                }
                break;
            case 23:
                {
                    this.AlienwareButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 174 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AlienwareButton).Click += this.AlienwareButton_Click;
                    #line default
                }
                break;
            case 24:
                {
                    this.MACHENIKEButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 178 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MACHENIKEButton).Click += this.MACHENIKEButton_Click;
                    #line default
                }
                break;
            case 25:
                {
                    this.MSIButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 182 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MSIButton).Click += this.MSIButton_Click;
                    #line default
                }
                break;
            case 26:
                {
                    this.SAMSUNGButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 186 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SAMSUNGButton).Click += this.SAMSUNGButton_Click;
                    #line default
                }
                break;
            case 27:
                {
                    this.RazerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 190 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.RazerButton).Click += this.RazerButton_Click;
                    #line default
                }
                break;
            case 28:
                {
                    this.TOSHIBAButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 194 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.TOSHIBAButton).Click += this.TOSHIBAButton_Click;
                    #line default
                }
                break;
            case 29:
                {
                    this.GIGABYTEButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 198 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.GIGABYTEButton).Click += this.GIGABYTEButton_Click;
                    #line default
                }
                break;
            case 30:
                {
                    this.TerransForceButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 202 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.TerransForceButton).Click += this.TerransForceButton_Click;
                    #line default
                }
                break;
            case 31:
                {
                    this.LenovoButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 206 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.LenovoButton).Click += this.LenovoButton_Click;
                    #line default
                }
                break;
            case 32:
                {
                    this.MiButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 210 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MiButton).Click += this.MiButton_Click;
                    #line default
                }
                break;
            case 36:
                {
                    this.ComputerNameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 37:
                {
                    this.SystemTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 38:
                {
                    this.CPUTypeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39:
                {
                    this.FrequencyTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 40:
                {
                    this.RamTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 41:
                {
                    this.RamTypeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 42:
                {
                    this.HardCapacityTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 43:
                {
                    this.SizeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 44:
                {
                    this.ResTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 45:
                {
                    this.GraphicsTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 46:
                {
                    this.GraphicsRamTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 47:
                {
                    this.GraphicsTypeTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 48:
                {
                    this.FindComputerListAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 265 "..\..\..\FindViews\Computer.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.FindComputerListAppBarButton).Click += this.FindComputerListAppBarButton_Click;
                    #line default
                }
                break;
            case 49:
                {
                    this.H0meAppBarButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 271 "..\..\..\FindViews\Computer.xaml"
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
                    Computer_obj1_Bindings bindings = new Computer_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 33:
                {
                    global::Windows.UI.Xaml.Controls.Grid element33 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Computer_obj33_Bindings bindings = new Computer_obj33_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::ElectricalParameters.Models.FindComputer) element33.DataContext);
                    element33.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element33, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

