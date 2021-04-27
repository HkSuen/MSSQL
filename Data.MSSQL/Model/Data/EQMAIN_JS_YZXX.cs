using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQMAIN_JS_YZXX
    {
           public EQMAIN_JS_YZXX(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUNR {get;set;}

           /// <summary>
           /// Desc:日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RQ {get;set;}

           /// <summary>
           /// Desc:本月运转(小时)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BYYZ {get;set;}

           /// <summary>
           /// Desc:大修后累计(小时)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DXHLJ {get;set;}

           /// <summary>
           /// Desc:总累计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZLJ {get;set;}

           /// <summary>
           /// Desc:登记人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DJR {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEDATE {get;set;}

           /// <summary>
           /// Desc:修改人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:计量单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JLDW {get;set;}

    }
}
