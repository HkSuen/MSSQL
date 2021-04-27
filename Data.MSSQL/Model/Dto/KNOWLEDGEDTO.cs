using System;
using System.Collections.Generic;
using System.Text;

using Data.MSSQL.Model.Data;

namespace Data.MSSQL.Model.Dto
{
    public class KNOWLEDGEDTO : KNOWLEDGES_INFOS
    {

        public string State
        {
            get
            {
                return STATUS == 2 ? "发布" : "制定";
            }
        }

        public string EQNAME { get; set; }

        public string NAME { get; set; }

        public string ORG_NAME { get; set; }        
    }
}
