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
using NatuurApp.BusinessLogicLayer;

namespace NatuurApp.GUI
{
    public partial class AddArea : PhoneApplicationPage
    {
        private AreaViewController AVC = new AreaViewController();
        public AddArea()
        {
            InitializeComponent();
        }

        private void btnAddArea_Click(object sender, RoutedEventArgs e)
        {
            Tbl_NatureArea tbl = new Tbl_NatureArea();
            tbl.AreaName = txtAreaName.Text;
            tbl.BestSeason = txtSeasonTip.Text;
            tbl.BriefDescription = txtExtendedDescription.Text;
            tbl.ExtendedDescription = txtExtendedDescription.Text;
            tbl.Latitude = Int32.Parse((txtLatitude.Text));
            tbl.Longitude = Int32.Parse(txtLongitude.Text);
            tbl.Location = txtLocation.Text;
            AVC.InsertArea(tbl,null);
            MessageBox.Show("area saved");
            Image1.Source.ToString();
           
            NavigationService.GoBack();
        }

        private void Image1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            
        }
    }
}