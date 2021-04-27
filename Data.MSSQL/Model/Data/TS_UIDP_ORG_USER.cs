using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_UIDP_ORG_USER
    {
           public TS_UIDP_ORG_USER(){


           }
           /// <summary>
           /// Desc:组织机构id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_ID {get;set;}

           /// <summary>
           /// Desc:用户id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_ID {get;set;}

    }
}
