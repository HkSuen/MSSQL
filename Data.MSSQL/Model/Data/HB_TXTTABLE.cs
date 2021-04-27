using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class HB_TXTTABLE
    {
           public HB_TXTTABLE(){


           }
           /// <summary>
           /// Desc:表名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TXT_TABLENAME {get;set;}

           /// <summary>
           /// Desc:字段多个字段以逗号分隔如col1,col2,col3 为空是全部
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TXT_TABLECOL {get;set;}

           /// <summary>
           /// Desc:是否读取0不读取 1读取
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TXT_ISREADER {get;set;}

           /// <summary>
           /// Desc:表主键，多个主键时用||分割
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TXT_PK {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DLDATE {get;set;}

    }
}
