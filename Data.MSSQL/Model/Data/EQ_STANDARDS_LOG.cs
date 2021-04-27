using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_STANDARDS_LOG
    {
           public EQ_STANDARDS_LOG(){


           }
           /// <summary>
           /// Desc:日志生成日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LOGDATE {get;set;}

           /// <summary>
           /// Desc:遍历日期耗时  单位:ms
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LOOPTIME {get;set;}

           /// <summary>
           /// Desc:修改过期数据耗时 单位:ms
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CHANGEDATATIME {get;set;}

           /// <summary>
           /// Desc:错误信息记录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ERRORMESSAGE {get;set;}

           /// <summary>
           /// Desc:修改数据的条数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CHANGENUMBER {get;set;}

           /// <summary>
           /// Desc:定时任务执行状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OPERATIONSTATE {get;set;}

    }
}
