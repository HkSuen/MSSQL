using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASKSUPERVISION_STATE
    {
           public EQ_TASKSUPERVISION_STATE(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:任务外键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RW_ID {get;set;}

           /// <summary>
           /// Desc:执行单位外键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ORG_CODE {get;set;}

           /// <summary>
           /// Desc:执行状态，-1催办,0待执行，1执行中，2已完成，
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? STATE {get;set;}

           /// <summary>
           /// Desc:上报时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? REPORT_TIME {get;set;}

    }
}
