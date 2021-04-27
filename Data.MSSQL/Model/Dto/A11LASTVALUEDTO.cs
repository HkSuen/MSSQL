using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL.Model.Dto
{
    public class A11LASTVALUEDTO
    {
        public string TagName { get; set; }
        public DateTime? TimeStamp { get; set; }
        public decimal? Value { get; set; }
        public int? Confiidence { get; set; }
        public string HostName { get; set; }
        public string Units { get; set; }
        public DateTime? FormatedTime { get; set; }
    }
}
