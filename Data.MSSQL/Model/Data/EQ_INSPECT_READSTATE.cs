using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_READSTATE
    {
           public EQ_INSPECT_READSTATE(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:任务主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TASK_ID {get;set;}

           /// <summary>
           /// Desc:阅读人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_ID {get;set;}

    }
}
