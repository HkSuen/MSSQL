using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASKSUPERVISION_GROUP
    {
           public EQ_TASKSUPERVISION_GROUP(){


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
           /// Nullable:False
           /// </summary>           
           public string RW_ID {get;set;}

           /// <summary>
           /// Desc:角色主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string GROUP_ID {get;set;}

           /// <summary>
           /// Desc:角色名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GROUP_NAME {get;set;}

    }
}
