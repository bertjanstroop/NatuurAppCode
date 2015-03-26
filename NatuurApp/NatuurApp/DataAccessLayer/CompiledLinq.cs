using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace NatuurApp.DataAccessLayer
{
    static class CompiledLinq
    {
        public static Func<Context, IQueryable<Tbl_NatureArea>> GetAreaList = CompiledQuery.Compile((Context dc) => from p in dc.Tbl_NatureArea select p);
        public static Func<Context, int, IQueryable<Tbl_NatureArea>> GetAreaByID = CompiledQuery.Compile((Context dc, int AreaID) => from p in dc.Tbl_NatureArea where p.AreaID == AreaID select p);
        public static Func<Context, int, IQueryable<Tbl_NatureAreaFoto>> GetAreaFotoByID = CompiledQuery.Compile((Context dc, int AreaID) => from p in dc.Tbl_NatureAreaFoto where p.AreaID == AreaID select p);
    }
}
