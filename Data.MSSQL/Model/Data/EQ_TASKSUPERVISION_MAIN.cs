using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASKSUPERVISION_MAIN
    {
           public EQ_TASKSUPERVISION_MAIN(){


           }
           /// <summary>
           /// Desc:督办主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:任务名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_NAME {get;set;}

           /// <summary>
           /// Desc:任务说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_EXPLAN {get;set;}

           /// <summary>
           /// Desc:任务编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RW_BH {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:任务状态(0,新建,1已下发,2已完成)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? RW_STATE {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? RW_STARTTIME {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? RW_ENDTIME {get;set;}

           /// <summary>
           /// Desc:任务模板的路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_TEM_PATH {get;set;}

    }
}
