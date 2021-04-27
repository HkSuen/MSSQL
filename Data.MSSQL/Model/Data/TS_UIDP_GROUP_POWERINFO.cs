using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_UIDP_GROUP_POWERINFO
    {
           public TS_UIDP_GROUP_POWERINFO(){


           }
           /// <summary>
           /// Desc:角色id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GROUP_ID {get;set;}

           /// <summary>
           /// Desc:菜单id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MENU_ID {get;set;}

    }
}
