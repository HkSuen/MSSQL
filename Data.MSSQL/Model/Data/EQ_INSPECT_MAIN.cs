using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_MAIN
    {
           public EQ_INSPECT_MAIN(){


           }
           /// <summary>
           /// Desc: 数据主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:检查任务编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_CODE {get;set;}

           /// <summary>
           /// Desc:检查任务名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_NAME {get;set;}

           /// <summary>
           /// Desc:检查开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? INS_DATE_START {get;set;}

           /// <summary>
           /// Desc:检查结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? INS_DATE_END {get;set;}

           /// <summary>
           /// Desc:检查分类编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_TYPE_CODE {get;set;}

           /// <summary>
           /// Desc:检查单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_JCDW_CODE {get;set;}

           /// <summary>
           /// Desc:检查设备数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? INS_EQ_COUNT {get;set;}

           /// <summary>
           /// Desc:任务状态INS_STAT: 0新增 1 执行中（下发后）2 已完成（创建任务的人手动自己点完成）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? INS_STAT {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_REMARK {get;set;}

           /// <summary>
           /// Desc:创建人单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_ORG_CODE {get;set;}

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

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:修改人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:任务下发时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? INS_DATE_PUSH {get;set;}

    }
}
