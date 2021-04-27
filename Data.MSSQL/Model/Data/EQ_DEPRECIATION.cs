using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_DEPRECIATION
    {
           public EQ_DEPRECIATION(){


           }
           /// <summary>
           /// Desc:主键ID
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
           /// Desc:设备型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUI_MODEL {get;set;}

           /// <summary>
           /// Desc:单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? EQUI_PRICE {get;set;}

           /// <summary>
           /// Desc:新增数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? EQUI_ADDNUMBER {get;set;}

           /// <summary>
           /// Desc:更新数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? EQUI_UPDATENUMBER {get;set;}

           /// <summary>
           /// Desc:本年度已下达
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? YEAR_MONEY {get;set;}

           /// <summary>
           /// Desc:本批计划已下达
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BATCH_MONEY {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:创建人组织机构编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATERORG {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:修改人
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
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

           /// <summary>
           /// Desc:申请年度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string APPLY_YEAR {get;set;}

    }
}
