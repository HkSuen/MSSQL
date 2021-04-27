using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_FUN_LISTED
    {
           public EQ_FUN_LISTED(){


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
           /// Desc:序号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string XH {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SBMC {get;set;}

           /// <summary>
           /// Desc:所对应标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TITLE {get;set;}

           /// <summary>
           /// Desc:规格型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GGXH {get;set;}

           /// <summary>
           /// Desc:购置数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? GZSL {get;set;}

           /// <summary>
           /// Desc:单价
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? DJ {get;set;}

           /// <summary>
           /// Desc:总投资
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZTZ {get;set;}

           /// <summary>
           /// Desc:至 年累计已下达投资
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZNDLJTZ {get;set;}

           /// <summary>
           /// Desc:2020年计划
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? JH {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ {get;set;}

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
           /// Desc:购置性质
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GZXZ {get;set;}

    }
}
