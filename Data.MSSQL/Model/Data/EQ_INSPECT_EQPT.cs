using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_EQPT
    {
           public EQ_INSPECT_EQPT(){


           }
           /// <summary>
           /// Desc:数据主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:被检查任务主键
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

           /// <summary>
           /// Desc:设备编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUNR {get;set;}

           /// <summary>
           /// Desc:车牌井号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZCPNO {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

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
