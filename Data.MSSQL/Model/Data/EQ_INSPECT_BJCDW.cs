using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_BJCDW
    {
           public EQ_INSPECT_BJCDW(){


           }
           /// <summary>
           /// Desc:数据ID
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
           /// Desc:被检查单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BJCDW_CODE {get;set;}

    }
}
