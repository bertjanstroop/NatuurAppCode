using System;
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
using System.Windows.Media.Imaging;
using System.IO;
using NatuurApp.DataAccessLayer.db;
namespace NatuurApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        private static AreaViewController AVC = new AreaViewController();
        private static AreaListController ALC = new AreaListController();
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            LoadListItems();
        }

        private void LoadListItems()
        {
            AreaStackPanel.Children.Clear();
            foreach (var item in CreateListItems())
            {
                AreaStackPanel.Children.Add(item);
            }
        }

        public static ImageSource ByteToImage(byte[] imageData)
        {
            BitmapImage biImg = new BitmapImage();
            MemoryStream ms = new MemoryStream(imageData);
            biImg.SetSource(ms);
            ImageSource imgSrc = biImg as ImageSource;
            return imgSrc;
        }

        private List<AreaListItem> CreateListItems()
        {
            List<AreaListItem> result = new List<AreaListItem>();
            var tmp = ALC.GetAreaList();
            foreach (Tbl_NatureArea item in tmp)
            {
                AreaListItem ali = new AreaListItem();
                ali.AreaID = item.AreaID;
                ali.AreaName.Text = item.AreaName;
                ali.AreaShortDescription.Text = item.BriefDescription;
                ali.AreaLocation.Text = item.Location;
                ali.AreaImage.Source = ByteToImage(ALC.GetAreaFotoByID(item.AreaID).Image1.ToArray());
                ali.nav = this.NavigationService;
                result.Add(ali);
            }

            return result;
        }

        private void ShowFullAreaView(int AreaID)
        {

        }

        private void btnAddArea_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GUI/AddArea.xaml", UriKind.Relative));
        }
    }
}