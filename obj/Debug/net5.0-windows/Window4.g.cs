﻿#pragma checksum "..\..\..\Window4.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91CD7009A759D7D13CA8B06D9B44BABCA2209C57"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MyVP1;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MyVP1 {
    
    
    /// <summary>
    /// Window4
    /// </summary>
    public partial class Window4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SexF;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SexM;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckMarried;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HeightText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider HeightSlider;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WeightText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider WeightSlider;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Window4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Сonfirm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyVP1;component/window4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window4.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SexF = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.SexM = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.DateBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.CheckMarried = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.HeightText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.HeightSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 27 "..\..\..\Window4.xaml"
            this.HeightSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.HeightSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.WeightText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.WeightSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 29 "..\..\..\Window4.xaml"
            this.WeightSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.WeightSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Сonfirm = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Window4.xaml"
            this.Сonfirm.Click += new System.Windows.RoutedEventHandler(this.Сonfirm_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
