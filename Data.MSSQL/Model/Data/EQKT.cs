using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQKT
    {
           public EQKT(){


           }
           /// <summary>
           /// Desc:客户端
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MANDT {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUNR {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SPRAS {get;set;}

           /// <summary>
           /// Desc:技术对象说名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQKTX {get;set;}

           /// <summary>
           /// Desc:长文本标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KZLTX {get;set;}

           /// <summary>
           /// Desc:正文部分的主要语言标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TXASP {get;set;}

           /// <summary>
           /// Desc:大写字母设备描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQKTU {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DLDATE {get;set;}

    }
}
