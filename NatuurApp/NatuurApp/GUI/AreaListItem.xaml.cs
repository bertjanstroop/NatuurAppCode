﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NatuurApp.GUI;

namespace NatuurApp
{
    public partial class AreaListItem : UserControl
    {
        public NavigationService nav { get; set; }
        public int AreaID { get; set; }
        public AreaListItem()
        {
            InitializeComponent();
        }

        private void UserControl_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            nav.Navigate(new Uri("/GUI/AreaView.xaml?AreaID=" + AreaID, UriKind.Relative));
        }
    }
}
