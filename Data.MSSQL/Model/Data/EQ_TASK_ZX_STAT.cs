using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASK_ZX_STAT
    {
           public EQ_TASK_ZX_STAT(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:外键id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_ID {get;set;}

           /// <summary>
           /// Desc:同一任务结果主键（多个状态同一id）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZX_ID {get;set;}

           /// <summary>
           /// Desc:执行单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXDW_CODE {get;set;}

           /// <summary>
           /// Desc:执行人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXR_ID {get;set;}

           /// <summary>
           /// Desc:执行状态0未确认、1待上报、2已上报、3已驳回、4已完成
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXZT {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

    }
}
