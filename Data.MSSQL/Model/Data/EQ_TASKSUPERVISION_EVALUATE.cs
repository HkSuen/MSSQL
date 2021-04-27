using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASKSUPERVISION_EVALUATE
    {
           public EQ_TASKSUPERVISION_EVALUATE(){


           }
           /// <summary>
           /// Desc:评论主键
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
           /// Desc:执行单位编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ORG_CODE {get;set;}

           /// <summary>
           /// Desc:评价内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CONTENT {get;set;}

           /// <summary>
           /// Desc:评分等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RATEVALUE {get;set;}

    }
}
