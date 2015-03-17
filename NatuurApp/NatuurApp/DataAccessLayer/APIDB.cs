using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Provider;
using NatuurApp.ServiceReference1;
using System.Collections;

namespace NatuurApp
{
    public class APIDB
    {
        private Service1Client API = new Service1Client();
        public APIDB() { }
        // Create the data context.
        public DataClass.NatureArea GetNatureAreaByID(string AreaID)
        {
            API.GetNatureAreaByIDCompleted += new EventHandler<GetNatureAreaByIDCompletedEventArgs>(GetNatureAreaByIDCompleted);
            API.GetNatureAreaByIDAsync(AreaID);
            return Values.Value;
        }

        static void GetNatureAreaByIDCompleted(object sender, GetNatureAreaByIDCompletedEventArgs e)
        {
            Values.Value.AreaID = e.Result.AreaID;
            Values.Value.AreaName = e.Result.AreaName;
            Values.Value.BriefDescription = e.Result.BriefDescription;
            Values.Value.ExtendedDescription = e.Result.ExtendedDescription;
            Values.Value.Latitude = e.Result.Latitude;
            Values.Value.Longitude = e.Result.Longitude;
            Values.Value.Location = e.Result.Location;
            Values.Value.BestSeason = e.Result.BestSeason;
        }

        public Link<DataClass.NatureArea> GetNatureAreaList()
        {
            API.GetNatureAreasCompleted += new EventHandler<GetNatureAreasCompletedEventArgs>(GetNatureAreaListCompleted);
            API.GetNatureAreasAsync();
            return Values.ListValue;
        }

        private void GetNatureAreaListCompleted(object sender, GetNatureAreasCompletedEventArgs e)
        {
            List<DataClass.NatureArea> Nalist = new List<DataClass.NatureArea>();
            foreach (var item in e.Result)
            {
                DataClass.NatureArea NA = new DataClass.NatureArea();
                NA.AreaID = item.AreaID;
                NA.AreaName = item.AreaName;
                NA.BriefDescription = item.BriefDescription;
                NA.ExtendedDescription = item.ExtendedDescription;
                NA.Latitude = item.Latitude;
                NA.Longitude = item.Longitude;
                NA.Location = item.Location;
                NA.BestSeason = item.BestSeason;
                Nalist.Add(NA);
            }
            Values.ListValue = Nalist;
        }
    }

    public static class Values
    {
        public static DataClass.NatureArea Value { get; set; }
        public static Link<DataClass.NatureArea> ListValue { get; set; }
    }
}
