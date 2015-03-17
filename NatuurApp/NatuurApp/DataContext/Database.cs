using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace NatuurApp.DataAccessLayer
{
    [Table(Name = "tbl_NatureArea")]
    public  class tbl_NatureArea
    {
        [Column(IsPrimaryKey= true,IsDbGenerated = true)]
        public int AreaID { get; set; }

        [Column(CanBeNull = true)]
        public string AreaName { get; set; }

        [Column(CanBeNull = true)]
        public string BriefDescription { get; set; }

        [Column(CanBeNull = true)]
        public string ExtendedDescription { get; set; }

        [Column(CanBeNull = true)]
        public string Latitude { get; set; }

        [Column(CanBeNull = true)]
        public string Longitude { get; set; }

        [Column(CanBeNull = true)]
        public string Location { get; set; }

        [Column(CanBeNull = true)]
        public string BestSeason { get; set; }
    }

    [Table(Name = "tbl_NatureAreaFoto")]
    public class tbl_NatureAreaFoto
    {
        [Column(IsPrimaryKey = true,IsDbGenerated = true)]
        public int ID { get; set; }

        [Column(CanBeNull = false)]
        public int AreaID { get; set; }

        [Column(CanBeNull = false)]
        public object Image1 {get;set;}

        [Column(CanBeNull = false)]
        public object Image2 { get; set; }

        [Column(CanBeNull = false)]
        public object Image3 { get; set; }

        [Column(CanBeNull = false)]
        public object Image4 { get; set; }
    }
    public class tbl_NatureAreaDataContext:DataContext
    {
        //public const string ConnectionString = "isostore:/database.sdf";
        public Table<tbl_NatureArea> tbl_NatureArea { get; set; }

        public tbl_NatureAreaDataContext(string connectionString)
            : base(connectionString)
        {
            this.tbl_NatureArea = this.GetTable<tbl_NatureArea>();
        }
    }

    public class tbl_NatureAreaFotoDataContext : DataContext
    {
                //public const string ConnectionString = "isostore:/database.sdf";
        public Table<tbl_NatureAreaFoto> tbl_NatureAreaFoto { get; set; }

        public tbl_NatureAreaFotoDataContext(string connectionString)
            : base(connectionString)
        {
            this.tbl_NatureAreaFoto = this.GetTable<tbl_NatureAreaFoto>();
        }
    }
}