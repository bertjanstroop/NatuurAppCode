﻿#pragma checksum "C:\NatuurAppCode\NatuurAppCode\NatuurApp\NatuurApp\GUI\AreaListItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EF6AF8FB39ED20FA640AB13C4C64E7B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace NatuurApp {
    
    
    public partial class AreaListItem : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock text1;
        
        internal System.Windows.Controls.Image AreaImage;
        
        internal System.Windows.Controls.TextBlock text2;
        
        internal System.Windows.Controls.TextBox AreaName;
        
        internal System.Windows.Controls.TextBox AreaShortDescription;
        
        internal System.Windows.Controls.TextBlock text3;
        
        internal System.Windows.Controls.TextBox AreaLocation;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/NatuurApp;component/GUI/AreaListItem.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.text1 = ((System.Windows.Controls.TextBlock)(this.FindName("text1")));
            this.AreaImage = ((System.Windows.Controls.Image)(this.FindName("AreaImage")));
            this.text2 = ((System.Windows.Controls.TextBlock)(this.FindName("text2")));
            this.AreaName = ((System.Windows.Controls.TextBox)(this.FindName("AreaName")));
            this.AreaShortDescription = ((System.Windows.Controls.TextBox)(this.FindName("AreaShortDescription")));
            this.text3 = ((System.Windows.Controls.TextBlock)(this.FindName("text3")));
            this.AreaLocation = ((System.Windows.Controls.TextBox)(this.FindName("AreaLocation")));
        }
    }
}

