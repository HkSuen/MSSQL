using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASKSUPERVISION_TEMCONFIG
    {
           public EQ_TASKSUPERVISION_TEMCONFIG(){


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
           /// Desc:表头名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LABEL {get;set;}

           /// <summary>
           /// Desc:统计类型(0数字,1字符串)非数字类型不参加统计
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal COLUMN_TYPE {get;set;}

           /// <summary>
           /// Desc:是否为列头，1为列头，0位行头
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal IS_COLUMN {get;set;}

           /// <summary>
           /// Desc:排序标识，生成EXCEL模板时使用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SORT_NUM {get;set;}

    }
}
