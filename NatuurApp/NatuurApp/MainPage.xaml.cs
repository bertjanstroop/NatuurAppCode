﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using NatuurApp.BusinessLogicLayer;
namespace NatuurApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        AreaViewController AVC = new AreaViewController();
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            DataAccessLayer.EmbededDB edb = new DataAccessLayer.EmbededDB();
            var test = edb.GetAreaByID(1);
        }
    }
}