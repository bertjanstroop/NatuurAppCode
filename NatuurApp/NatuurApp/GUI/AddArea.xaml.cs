using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NatuurApp.DataAccessLayer.db;

namespace NatuurApp.GUI
{
    public partial class AddArea : PhoneApplicationPage
    {
        public AddArea()
        {
            InitializeComponent();
        }

        private void btnAddArea_Click(object sender, RoutedEventArgs e)
        {
            EmbededDB DB = new EmbededDB();
            DB.InsertArea(tbAreaName.Text,tbAreaDescription.Text,tbAreaLocation.Text);
            NavigationService.GoBack();
        }
    }
}