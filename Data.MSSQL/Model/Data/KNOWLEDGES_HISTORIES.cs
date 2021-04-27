using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class KNOWLEDGES_HISTORIES
    {
           public KNOWLEDGES_HISTORIES(){


           }
           /// <summary>
           /// Desc:标识
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:知识库ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INFO_ID {get;set;}

           /// <summary>
           /// Desc:记录操作(1.阅读；2.下载)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OPERATION {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATE_TIME {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATOR {get;set;}

    }
}
