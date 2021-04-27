using Data.MSSQL.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL.Model.Dto
{
    public class NoInvestmentPlansDto : EQ_NONINSINVESTMENTPLAN
    {
        public string S_ID { get; set; }
        public string NAME { get; set; }
    }
}
