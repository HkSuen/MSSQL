using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_UIDP_GROUPINFO
    {
           public TS_UIDP_GROUPINFO(){


           }
           /// <summary>
           /// Desc:系统编号 不同的系统下权限组不同
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYS_CODE {get;set;}

           /// <summary>
           /// Desc:角色id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GROUP_ID {get;set;}

           /// <summary>
           /// Desc:角色编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GROUP_CODE {get;set;}

           /// <summary>
           /// Desc:角色名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GROUP_NAME {get;set;}

           /// <summary>
           /// Desc:上级角色id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GROUP_CODE_UPPER {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

    }
}
