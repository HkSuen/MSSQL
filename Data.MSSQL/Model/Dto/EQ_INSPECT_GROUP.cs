using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL.Model.Dto
{
    public class EQ_INSPECT_GROUP : Data.EQ_INSPECT_GROUP
    {
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<Data.EQ_INSPECT_GROUP_DETAIL> details { get; set; } = new List<Data.EQ_INSPECT_GROUP_DETAIL>();

        //[SqlSugar.SugarColumn(IsIgnore = true)]
        //public string ORG_SHORT_NAME { get; set; }
    }
}
