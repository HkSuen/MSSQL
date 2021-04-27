using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASKSUPERVISION_ORG
    {
           public EQ_TASKSUPERVISION_ORG(){


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
           /// Desc:组织机构编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ORG_CODE {get;set;}

           /// <summary>
           /// Desc:组织机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_NAME {get;set;}

           /// <summary>
           /// Desc:组织机构ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ORG_ID {get;set;}

    }
}
