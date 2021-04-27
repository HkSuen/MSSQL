using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_ZX_LX
    {
           public EQ_INSPECT_ZX_LX(){


           }
           /// <summary>
           /// Desc:数据主键id
           /// Default:
           /// Nullable:True
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
           /// Desc:零星检查编码（自动生成）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LX_CODE {get;set;}

           /// <summary>
           /// Desc:零星检查名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LX_NAME {get;set;}

           /// <summary>
           /// Desc:检查情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LX_RESULT {get;set;}

           /// <summary>
           /// Desc:分值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LX_SCORE {get;set;}

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
