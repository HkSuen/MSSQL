using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQMAIN_EQTYP
    {
           public EQMAIN_EQTYP(){


           }
           /// <summary>
           /// Desc:设备种类编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EQTYP {get;set;}

           /// <summary>
           /// Desc:父级编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PEQTYP {get;set;}

           /// <summary>
           /// Desc:设备种类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQNAME {get;set;}

           /// <summary>
           /// Desc:型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQXH {get;set;}

           /// <summary>
           /// Desc:级别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQJB {get;set;}

           /// <summary>
           /// Desc:是否是明细级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQSFMX {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEDATE {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEDATE {get;set;}

    }
}
