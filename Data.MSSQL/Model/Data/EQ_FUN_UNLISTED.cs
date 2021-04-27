using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_FUN_UNLISTED
    {
           public EQ_FUN_UNLISTED(){


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
           /// Desc:购置性质
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GZXZ {get;set;}

           /// <summary>
           /// Desc:购置数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? GZSL {get;set;}

           /// <summary>
           /// Desc:总投资
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZTZ {get;set;}

           /// <summary>
           /// Desc:至 年底累计下达投资
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZNDLJTZ {get;set;}

           /// <summary>
           /// Desc:配送小计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Y_XJ {get;set;}

           /// <summary>
           /// Desc:企业自有资金
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Y_QYZYZJ {get;set;}

           /// <summary>
           /// Desc:集团公司投资
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Y_JTGSTZ {get;set;}

           /// <summary>
           /// Desc:贷款
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Y_DK {get;set;}

           /// <summary>
           /// Desc:金融租赁/信托
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Y_JRXT {get;set;}

           /// <summary>
           /// Desc:其他
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? Y_QT {get;set;}

           /// <summary>
           /// Desc:可研批准文号及备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KYPZWHJBZ {get;set;}

           /// <summary>
           /// Desc:目标市场（xx油田、xx国家、xx项目）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MBSC {get;set;}

           /// <summary>
           /// Desc:拟更新设备投产年限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NGXSBTCNX {get;set;}

           /// <summary>
           /// Desc:年增收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? XY_NZSR {get;set;}

           /// <summary>
           /// Desc:年均利润总额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string XY_NJLRZE {get;set;}

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
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQ_NAME {get;set;}

    }
}
