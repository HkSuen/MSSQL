using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQMAIN_FILE
    {
           public EQMAIN_FILE(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:外键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PF_ID {get;set;}

           /// <summary>
           /// Desc:文件名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILE_NAME {get;set;}

           /// <summary>
           /// Desc:文件地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILE_URL {get;set;}

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
           public string CREATEBY {get;set;}

    }
}
