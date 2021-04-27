using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_UIDP_LOGIN_USER
    {
           public TS_UIDP_LOGIN_USER(){


           }
           /// <summary>
           /// Desc:主账号id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LOGIN_ID {get;set;}

           /// <summary>
           /// Desc:关联账号id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_ID {get;set;}

    }
}
