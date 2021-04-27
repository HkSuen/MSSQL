using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASK_ZX
    {
           public EQ_TASK_ZX(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:状态外键ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZX_ID {get;set;}

           /// <summary>
           /// Desc:任务ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_ID {get;set;}

           /// <summary>
           /// Desc:执行单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZX_ZXDW_CODE {get;set;}

           /// <summary>
           /// Desc:执行人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZX_ZXR_ID {get;set;}

           /// <summary>
           /// Desc:上报说明内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZX_REMARK {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:修改人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:状态（0待上报、1已上报、2待审核 3已驳回、4已完成）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? ZXZT {get;set;}

           /// <summary>
           /// Desc:审批结果说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZX_APPROVALRESULT {get;set;}

    }
}
