﻿#pragma checksum "..\..\..\WindowSV.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B3F528F2AB987B4DEA37A7A3E1B82F35F7E7A011"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QLD_HP_CTH;
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


namespace QLD_HP_CTH {
    
    
    /// <summary>
    /// WindowSV
    /// </summary>
    public partial class WindowSV : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\WindowSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChiTiet;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\WindowSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKhung;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\WindowSV.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Information;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QLD_HP_CTH;component/windowsv.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowSV.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\WindowSV.xaml"
            ((QLD_HP_CTH.WindowSV)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\..\WindowSV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHome_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\WindowSV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMonHoc_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 20 "..\..\..\WindowSV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnChuongTrinh_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 21 "..\..\..\WindowSV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnHocPhi_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 22 "..\..\..\WindowSV.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnBangDiem_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnChiTiet = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\WindowSV.xaml"
            this.btnChiTiet.Click += new System.Windows.RoutedEventHandler(this.btnChiTiet_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnKhung = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\WindowSV.xaml"
            this.btnKhung.Click += new System.Windows.RoutedEventHandler(this.btnKhung_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Information = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

