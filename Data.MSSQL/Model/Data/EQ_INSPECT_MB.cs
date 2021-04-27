using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_MB
    {
           public EQ_INSPECT_MB(){


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
           /// Desc:模板ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_TEM_ID {get;set;}

           /// <summary>
           /// Desc:模板备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_REMARK {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

    }
}
