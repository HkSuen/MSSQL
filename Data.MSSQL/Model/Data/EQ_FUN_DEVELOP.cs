using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_FUN_DEVELOP
    {
           public EQ_FUN_DEVELOP(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:EQ_FUNDINGPLANS主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PID {get;set;}

           /// <summary>
           /// Desc:纵向标题（Dictionary主键）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TITLE {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATER {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATETIME {get;set;}

           /// <summary>
           /// Desc:序号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? XH {get;set;}

           /// <summary>
           /// Desc:设备名称及规格型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SBMCJGGXH {get;set;}

           /// <summary>
           /// Desc:单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DJ {get;set;}

           /// <summary>
           /// Desc:数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SL {get;set;}

           /// <summary>
           /// Desc:本年度已下达
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BJDYXD {get;set;}

           /// <summary>
           /// Desc:本批计划投资
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BPJHTZ {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ {get;set;}

           /// <summary>
           /// Desc:批次
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? NO {get;set;}

    }
}
