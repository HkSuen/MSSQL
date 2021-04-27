using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQMAIN_JS_SHSG
    {
           public EQMAIN_JS_SHSG(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
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
           /// Desc:发生地
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FSD {get;set;}

           /// <summary>
           /// Desc:事故性质
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SGXZ {get;set;}

           /// <summary>
           /// Desc:事故原因
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SGYY {get;set;}

           /// <summary>
           /// Desc:机件损坏情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JJSHQK {get;set;}

           /// <summary>
           /// Desc:损失价值(元)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SSJZ {get;set;}

           /// <summary>
           /// Desc:责任者
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZRZ {get;set;}

           /// <summary>
           /// Desc:责任者职务
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZRZZW {get;set;}

           /// <summary>
           /// Desc:处理结果
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CLJG {get;set;}

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
