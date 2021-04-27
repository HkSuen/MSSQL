using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_UIDP_ACCESSTOKEN
    {
           public TS_UIDP_ACCESSTOKEN(){


           }
           /// <summary>
           /// Desc:用户id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_ID {get;set;}

           /// <summary>
           /// Desc:token串
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ACCESS_TOKEN {get;set;}

           /// <summary>
           /// Desc:过期时间yyyy-mm-dd:hh:mm:ss
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EXPIRED_TIME {get;set;}

    }
}
