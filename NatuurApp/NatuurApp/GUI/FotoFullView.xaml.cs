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
    public partial class FotoFullView : PhoneApplicationPage
    {
        public FotoFullView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            FullImage.Source = StaticData.FullImage.Source;
        }
    }
}