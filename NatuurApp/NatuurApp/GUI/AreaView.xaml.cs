using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NatuurApp.BusinessLogicLayer;

namespace NatuurApp.GUI
{
    public partial class AreaView : PhoneApplicationPage
    {
        public int AreaID;
        private Tbl_NatureArea NatureArea = new Tbl_NatureArea();
        private Tbl_NatureAreaFoto NatureAreaFoto = new Tbl_NatureAreaFoto();
        private AreaViewController AVC = new AreaViewController();
        public AreaView()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            NatureArea_LoadData();
            NatureAreaFoto_LoadData();
            FillScreen();
        }

        private void NatureArea_LoadData()
        {
            NatureArea = AVC.GetAreaByID(AreaID);
        }

        private void NatureAreaFoto_LoadData()
        {
            NatureAreaFoto = AVC.GetAreaFotoByID(AreaID);
        }

        private void FillScreen()
        {
            txtAreaName.Text = NatureArea.AreaName;
            txtExtendedDescription.Text = NatureArea.ExtendedDescription;
            txtLatitude.Text = "" + NatureArea.Latitude;
            txtLongitude.Text = "" + NatureArea.Longitude;
            txtLocation.Text = NatureArea.Location;
            txtSeasonTip.Text = NatureArea.BestSeason;

            Image1.Source = ImageConvert.ByteToImage(NatureAreaFoto.Image1.ToArray());
            Image2.Source = ImageConvert.ByteToImage(NatureAreaFoto.Image2.ToArray());
            Image3.Source = ImageConvert.ByteToImage(NatureAreaFoto.Image3.ToArray());
            Image4.Source = ImageConvert.ByteToImage(NatureAreaFoto.Image4.ToArray());
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string parameter = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("AreaID", out parameter))
            {
                this.AreaID = int.Parse(parameter);
            }
        }
    }
}