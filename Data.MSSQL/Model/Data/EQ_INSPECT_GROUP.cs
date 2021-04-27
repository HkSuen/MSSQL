using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_GROUP
    {
           public EQ_INSPECT_GROUP(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:检查任务主键ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_ID {get;set;}

           /// <summary>
           /// Desc:被检查单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string G_BJCDW_CODE {get;set;}

           /// <summary>
           /// Desc:小组名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string G_NAME {get;set;}

           /// <summary>
           /// Desc:检查设备数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? G_COUNT {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string G_REMARK {get;set;}

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
           /// Desc:修改人IDs
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UPDATEBY {get;set;}

           /// <summary>
           /// Desc:被检查单位名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string G_BJCDW_NAME {get;set;}

    }
}
