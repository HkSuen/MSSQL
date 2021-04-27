using Data.MSSQL.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL.Model.Dto
{
    public class EQ_INSPECT_MAIN : Data.EQ_INSPECT_MAIN
    {
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<EQ_INSPECT_BJCDW> BJCDWs { get; set; }
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<EQ_INSPECT_XXTX> XXTXs { get; set; }
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<EQMAIN_FILE> FILEs { get; set; }

        [SqlSugar.SugarColumn(IsIgnore = true)]
        public int MaxNum { get; set; }
    }
}
