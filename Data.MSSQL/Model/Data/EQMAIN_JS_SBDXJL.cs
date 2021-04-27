using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQMAIN_JS_SBDXJL
    {
           public EQMAIN_JS_SBDXJL(){


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
           /// Desc:上次大修后运转时间（小时）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SCDXHYZSJ {get;set;}

           /// <summary>
           /// Desc:总累计运转时间（小时）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZLJYZSJ {get;set;}

           /// <summary>
           /// Desc:进厂日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JCRQ {get;set;}

           /// <summary>
           /// Desc:出厂日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CCRQ {get;set;}

           /// <summary>
           /// Desc:承修单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CXDW {get;set;}

           /// <summary>
           /// Desc:验收人员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YSRY {get;set;}

           /// <summary>
           /// Desc:修理前的主要问题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string XLQDZYWT {get;set;}

           /// <summary>
           /// Desc:更换的主要零部件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GHDZYLBJ {get;set;}

           /// <summary>
           /// Desc:验收结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YSJG {get;set;}

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
