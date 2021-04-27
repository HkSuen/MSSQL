using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASK_DW
    {
           public EQ_TASK_DW(){


           }
           /// <summary>
           /// Desc:主键id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:外键ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PF_ID {get;set;}

           /// <summary>
           /// Desc:执行单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_ZXDW_CODE {get;set;}

           /// <summary>
           /// Desc:执行人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_ZXR_ID {get;set;}

           /// <summary>
           /// Desc:是否指派给其他人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? RW_SFZP {get;set;}

           /// <summary>
           /// Desc:被指派执行人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_ZPZXR {get;set;}

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
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:修改人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:催办次数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? RW_CBCS {get;set;}

           /// <summary>
           /// Desc:状态（0 待确认 1已确认）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? ZXZT {get;set;}

    }
}
