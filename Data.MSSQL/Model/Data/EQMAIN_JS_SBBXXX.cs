using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQMAIN_JS_SBBXXX
    {
           public EQMAIN_JS_SBBXXX(){


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
           /// Desc:承修单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CXDW {get;set;}

           /// <summary>
           /// Desc:维保日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WBRQ {get;set;}

           /// <summary>
           /// Desc:维保类别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WBLB {get;set;}

           /// <summary>
           /// Desc:更换主要零部件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GHDZYLBJ {get;set;}

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

    }
}
