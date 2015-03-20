using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace NatuurApp.GUI
{
    public partial class AreaView : PhoneApplicationPage
    {
        public int AreaID;
        public AreaView()
        {
            InitializeComponent();
            string parameter = string.Empty;
            
            if (this.NavigationContext.QueryString.TryGetValue("AreaID", out parameter))
            {
                this.AreaID = int.Parse(parameter);
            }
        }
    }
}