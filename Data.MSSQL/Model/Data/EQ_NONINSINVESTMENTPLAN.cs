using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_NONINSINVESTMENTPLAN
    {
           public EQ_NONINSINVESTMENTPLAN(){


           }
           /// <summary>
           /// Desc:数据主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:字典购置性质外键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PURCHASE_PROPERTY {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:购置数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? AMOUNT {get;set;}

           /// <summary>
           /// Desc:总投资
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? TOTAL_INVESTMENT {get;set;}

           /// <summary>
           /// Desc:至2019年累计已下达的投资（万元）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? HISTORY_INVESTMENT {get;set;}

           /// <summary>
           /// Desc:小计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? SUBTOTAL {get;set;}

           /// <summary>
           /// Desc:企业自有资金
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? PRIVATE_CAPITAL {get;set;}

           /// <summary>
           /// Desc:集团公司投资
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? GROUP_INVESTMENT {get;set;}

           /// <summary>
           /// Desc:贷款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? LOAN {get;set;}

           /// <summary>
           /// Desc:金融租赁/信托
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? FINANCIAL_LEASING {get;set;}

           /// <summary>
           /// Desc:其他
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? OTHER {get;set;}

           /// <summary>
           /// Desc:可研批准文号及备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DOCUMENT_NUMBER {get;set;}

           /// <summary>
           /// Desc:目标市场（**油田/**国家**项目）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TARGETED_MARKET {get;set;}

           /// <summary>
           /// Desc:拟更新设备投产年限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PRODUCTION_YEARS {get;set;}

           /// <summary>
           /// Desc:年增收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ANNUAL_INCOME {get;set;}

           /// <summary>
           /// Desc:年均利润总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? AVERAGE_TOTAL_LPROFIT {get;set;}

           /// <summary>
           /// Desc:设备名称 (字段外键)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DICTIONARYID {get;set;}

           /// <summary>
           /// Desc:上报单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UNIT_CODE {get;set;}

    }
}
