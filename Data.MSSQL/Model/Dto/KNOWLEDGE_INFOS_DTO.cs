using Data.MSSQL.Model.Data;

using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL.Model.Dto
{
    public class KNOWLEDGE_INFOS_DTO : KNOWLEDGES_INFOS
    {
        public string[] LABELS { get; set; }

        public List<KNOWLEDGES_RELATIONS> GetLABELS()
        {
            List<KNOWLEDGES_RELATIONS> labels = new List<KNOWLEDGES_RELATIONS>();
            for (int i = 0; i < LABELS.Length; i++)
            {
                labels.Add(new KNOWLEDGES_RELATIONS() { 
                    ID = Guid.NewGuid().ToString("N"),
                    INFO_ID = this.ID,
                    LABEL_ID = LABELS[i].ToString()
                });
            }
            return labels;
        }
    }
}
