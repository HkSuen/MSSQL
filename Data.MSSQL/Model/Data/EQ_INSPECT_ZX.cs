using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_ZX
    {
           public EQ_INSPECT_ZX(){


           }
           /// <summary>
           /// Desc:数据主键id
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

           /// <summary>
           /// Desc:检查类型(1设备2综合)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_TYPE {get;set;}

           /// <summary>
           /// Desc:设备编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUNR {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQKTX {get;set;}

           /// <summary>
           /// Desc:车牌井号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZCPNO {get;set;}

           /// <summary>
           /// Desc:评分表主键id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ITME_ID {get;set;}

           /// <summary>
           /// Desc:评分模板id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TEMP_ID {get;set;}

           /// <summary>
           /// Desc:扣分
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? KF {get;set;}

           /// <summary>
           /// Desc:得分
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DF {get;set;}

           /// <summary>
           /// Desc:扣分原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KFYY {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:修改人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

    }
}
