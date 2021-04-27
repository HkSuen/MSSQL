using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_FUNDINGPLANS
    {
           public EQ_FUNDINGPLANS(){


           }
           /// <summary>
           /// Desc: 主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:年份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YEAR {get;set;}

           /// <summary>
           /// Desc:单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORGCODE {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATER {get;set;}

           /// <summary>
           /// Desc:状态：0待上报  1 已上报 2已审核
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? STATE {get;set;}

           /// <summary>
           /// Desc:纵向标题（Type主类型）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TYPE {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATETIME {get;set;}

           /// <summary>
           /// Desc:批次
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BATCH {get;set;}

    }
}
