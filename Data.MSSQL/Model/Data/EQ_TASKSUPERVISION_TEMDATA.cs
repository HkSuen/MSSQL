using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASKSUPERVISION_TEMDATA
    {
           public EQ_TASKSUPERVISION_TEMDATA(){


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
           /// Desc:数据所在列的模板的ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string COLUMN_ID {get;set;}

           /// <summary>
           /// Desc:数据所在的行的模板ID（当无行头时会通过存入不同的数字进行数据的区分）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ROW_ID {get;set;}

           /// <summary>
           /// Desc:数据的值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DATA {get;set;}

    }
}
