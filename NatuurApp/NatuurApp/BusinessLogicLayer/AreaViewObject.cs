using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatuurApp.BusinessLogicLayer
{
    class AreaViewObject
    {
        public int AreaID { get; set; }
        public string AreaName { get; set; }
        public string BriefDescription { get; set; }
        public string ExtendedDescription { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Location { get; set; }
        public string BestSeason { get; set; }
    }
}
