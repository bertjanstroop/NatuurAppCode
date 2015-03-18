using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace NatuurApp
{
    public partial class AreaListItem : UserControl
    {
        public int AreaID { get; set; }
        public AreaListItem()
        {
            InitializeComponent();
        }
    }
}
