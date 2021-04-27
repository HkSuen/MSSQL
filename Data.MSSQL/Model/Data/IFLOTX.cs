using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class IFLOTX
    {
           public IFLOTX(){


           }
           /// <summary>
           /// Desc:客户端
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MANDT {get;set;}

           /// <summary>
           /// Desc:功能位置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TPLNR {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SPRAS {get;set;}

           /// <summary>
           /// Desc:功能位置描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLTXT {get;set;}

           /// <summary>
           /// Desc:长文本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string XZLTX {get;set;}

           /// <summary>
           /// Desc:正文部分的主要语言标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string XZMLA {get;set;}

           /// <summary>
           /// Desc:大写字母中功能位置的描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLTXU {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DLDATE {get;set;}

    }
}
