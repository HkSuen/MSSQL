using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INVESTMENTPLAN
    {
           public EQ_INVESTMENTPLAN(){


           }
           /// <summary>
           /// Desc:数据主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQ_NAME {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATER {get;set;}

           /// <summary>
           /// Desc:购置性质
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PURCHASE_PROPERTY {get;set;}

           /// <summary>
           /// Desc:规格型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SPECIFICATION {get;set;}

           /// <summary>
           /// Desc:购置数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? AMOUNT {get;set;}

           /// <summary>
           /// Desc:单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? UNIT_PRICE {get;set;}

           /// <summary>
           /// Desc:至2019年累计已下达的投资（万元）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? HISTORY_INVESTMENT {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARKS {get;set;}

           /// <summary>
           /// Desc:设备类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUIPMENT_TYPE {get;set;}

           /// <summary>
           /// Desc:单位ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UNIT_CODE {get;set;}

    }
}
