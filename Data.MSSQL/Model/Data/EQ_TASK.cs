using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_TASK
    {
           public EQ_TASK(){


           }
           /// <summary>
           /// Desc:记录ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:任务编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RWBH {get;set;}

           /// <summary>
           /// Desc:任务分类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RWFL {get;set;}

           /// <summary>
           /// Desc:任务名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RWMC {get;set;}

           /// <summary>
           /// Desc:单位（系统自动生成/登陆人单位）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RWDW_CODE {get;set;}

           /// <summary>
           /// Desc:任务状态 0 草稿、 1 执行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? RWZT {get;set;}

           /// <summary>
           /// Desc:任务内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RWNR {get;set;}

           /// <summary>
           /// Desc:完成时间开始
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? RW_START_DATE {get;set;}

           /// <summary>
           /// Desc:完成时间结束
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? RW_END_DATE {get;set;}

           /// <summary>
           /// Desc:牵头单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RW_QTDW {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:修改人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

    }
}
