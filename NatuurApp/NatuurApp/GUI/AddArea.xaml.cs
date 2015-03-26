using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NatuurApp.DataAccessLayer.db;
using NatuurApp.BusinessLogicLayer;
using Microsoft.Phone.Tasks;

namespace NatuurApp.GUI
{
    public partial class AddArea : PhoneApplicationPage
    {
        Tbl_NatureAreaFoto tblFoto = new Tbl_NatureAreaFoto();
        Tbl_NatureArea tblArea = new Tbl_NatureArea();
        private AreaViewController AVC = new AreaViewController();
        public AddArea()
        {
            InitializeComponent();
        }

        private void btnAddArea_Click(object sender, RoutedEventArgs e)
        {
            tblArea.AreaName = txtAreaName.Text;
            tblArea.BestSeason = txtSeasonTip.Text;
            tblArea.BriefDesciption = txtBriefDescription.Text;
            tblArea.ExtendedDescription = txtExtendedDescription.Text;
            tblArea.Latitude = txtLatitude.Text;
            tblArea.Longitude = txtLongitude.Text;
            tblArea.Location = txtLocation.Text;
            AVC.InsertArea(tblArea,tblFoto);
            MessageBox.Show("area saved");
            
            NavigationService.GoBack();
        }

        private void btnAddImage1_Click(object sender, RoutedEventArgs e)
        {
            PhotoChooserTask pct = new PhotoChooserTask();
            pct.Completed += new EventHandler<PhotoResult>(pct_CompletedImage1);
            pct.Show();
            
            
        }

        void pct_CompletedImage1(object sender, PhotoResult e)
        {
            e.ChosenPhoto.Position = 0;
            var Bytes1 = new byte[e.ChosenPhoto.Length];
            e.ChosenPhoto.Read(Bytes1, 0, (int)e.ChosenPhoto.Length);
            tblFoto.Image1 = Bytes1;
            txtImagePath1.Text = e.OriginalFileName.ToString();
        }

        private void btnAddImage2_Click(object sender, RoutedEventArgs e)
        {
            PhotoChooserTask pct = new PhotoChooserTask();
            pct.Completed += new EventHandler<PhotoResult>(pct_CompletedImage2);
            pct.Show();
        }

        void pct_CompletedImage2(object sender, PhotoResult e)
        {
            e.ChosenPhoto.Position = 0;
            var Bytes2 = new byte[e.ChosenPhoto.Length];
            e.ChosenPhoto.Read(Bytes2, 0, (int)e.ChosenPhoto.Length);
            tblFoto.Image2 = Bytes2;
            txtImagePath2.Text = e.OriginalFileName.ToString();
        }

        private void btnAddImage3_Click(object sender, RoutedEventArgs e)
        {
            PhotoChooserTask pct = new PhotoChooserTask();
            pct.Completed += new EventHandler<PhotoResult>(pct_CompletedImage3);
            pct.Show();
        }

        void pct_CompletedImage3(object sender, PhotoResult e)
        {
            e.ChosenPhoto.Position = 0;
            var Bytes3 = new byte[e.ChosenPhoto.Length];
            e.ChosenPhoto.Read(Bytes3, 0, (int)e.ChosenPhoto.Length);
            tblFoto.Image3 = Bytes3;
            txtImagePath3.Text = e.OriginalFileName.ToString();
        }
        private void btnAddImage4_Click(object sender, RoutedEventArgs e)
        {
            PhotoChooserTask pct = new PhotoChooserTask();
            pct.Completed += new EventHandler<PhotoResult>(pct_CompletedImage4);
            pct.Show();
        }

        void pct_CompletedImage4(object sender, PhotoResult e)
        {
            e.ChosenPhoto.Position = 0;
            var Bytes4 = new byte[e.ChosenPhoto.Length];
            e.ChosenPhoto.Read(Bytes4, 0, (int)e.ChosenPhoto.Length);
            tblFoto.Image4 = Bytes4;
            txtImagePath4.Text = e.OriginalFileName.ToString();
        }
    }
}