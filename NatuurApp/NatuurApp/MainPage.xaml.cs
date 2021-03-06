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
using System.Windows.Media.Imaging;
using System.IO;
using NatuurApp.DataAccessLayer.db;
using System.ComponentModel;
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

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Application.Current.RootVisual.Dispatcher.BeginInvoke(LoadListItems);
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            Application.Current.RootVisual.Dispatcher.BeginInvoke(LoadListItems);
        }

        private void LoadListItems()
        {
            AreaStackPanel.Children.Clear();
            foreach (var item in AreaStackPanel.Children)
            {
                item.Tap -= new EventHandler<GestureEventArgs>(HandleAreaListTap);
            }
            foreach (var item in CreateListItems())
            {
                AreaStackPanel.Children.Add(item);
                item.Tap += new EventHandler<GestureEventArgs>(HandleAreaListTap);
            }
        }

        private void HandleAreaListTap(object sender, GestureEventArgs e)
        {
            var tmp = sender as AreaListItem;

            NavigationService.Navigate(new Uri("/GUI/AreaView.xaml?AreaID=" + tmp.AreaID, UriKind.Relative));
        }

        public List<AreaListItem> CreateListItems()
        {
            List<AreaListItem> result = new List<AreaListItem>();
            var tmp = ALC.GetAreaList();
            foreach (Tbl_NatureArea item in tmp)
            {
                AreaListItem ali = new AreaListItem();
                ali.AreaID = item.AreaID;
                ali.AreaName.Text = item.AreaName;
                ali.AreaShortDescription.Text = item.BriefDesciption;
                ali.AreaLocation.Text = item.Location;
                ali.AreaImage.Source = ImageConvert.ByteToImage(ALC.GetAreaFotoByID(item.AreaID).Image1.ToArray());
                ali.nav = this.NavigationService;
                result.Add(ali);
            }
            return result;
        }

        private void btnAddArea_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.RootVisual.Dispatcher.BeginInvoke(worker_DoWork);
        }

        void worker_DoWork()
        {
            NavigationService.Navigate(new Uri("/GUI/AddArea.xaml", UriKind.Relative));
        }
    }
}