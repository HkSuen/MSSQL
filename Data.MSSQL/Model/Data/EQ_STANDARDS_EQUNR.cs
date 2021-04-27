using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_STANDARDS_EQUNR
    {
           public EQ_STANDARDS_EQUNR(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:规程主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STANDARDS_ID {get;set;}

           /// <summary>
           /// Desc:设备编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUNR {get;set;}

    }
}
