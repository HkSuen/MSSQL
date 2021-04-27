using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INVESTMENTEQUI
    {
           public EQ_INVESTMENTEQUI(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUI_NAME {get;set;}

           /// <summary>
           /// Desc:单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? EQUI_PRICE {get;set;}

           /// <summary>
           /// Desc:数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? EQUI_NUMBER {get;set;}

           /// <summary>
           /// Desc:本年度已经下达资金(万元)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? YEAR_MONEY {get;set;}

           /// <summary>
           /// Desc:本批计划投资(万元)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BATCH_MONEY {get;set;}

           /// <summary>
           /// Desc:申请年度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string APPLY_YEAR {get;set;}

           /// <summary>
           /// Desc:创建人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:创建单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEORGCODE {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:修改人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:修改日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:设备类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUI_TYPE {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

    }
}
