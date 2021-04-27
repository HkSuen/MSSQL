using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class JEST
    {
           public JEST(){


           }
           /// <summary>
           /// Desc:客户端
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MANDT {get;set;}

           /// <summary>
           /// Desc:对象号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OBJNR {get;set;}

           /// <summary>
           /// Desc:对象状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STAT {get;set;}

           /// <summary>
           /// Desc:指示符，状态未激活
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INACT {get;set;}

           /// <summary>
           /// Desc:更改编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CHGNR {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DLDATE {get;set;}

    }
}
