using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQMAIN_IMG
    {
           public EQMAIN_IMG(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUNR {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IMG_PATH {get;set;}

           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:是否主照片 1是 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IS_ENABLE {get;set;}

    }
}
