using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_XXTX
    {
           public EQ_INSPECT_XXTX(){


           }
           /// <summary>
           /// Desc:数据主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:检查任务主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_ID {get;set;}

           /// <summary>
           /// Desc:角色编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ROLE_CODE {get;set;}

    }
}
