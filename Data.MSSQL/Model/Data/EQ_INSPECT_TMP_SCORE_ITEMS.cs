using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_TMP_SCORE_ITEMS
    {
           public EQ_INSPECT_TMP_SCORE_ITEMS(){


           }
           /// <summary>
           /// Desc:数据主键id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:模板表主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_TMP_ID {get;set;}

           /// <summary>
           /// Desc:检查项目
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SCORE_ITEM {get;set;}

           /// <summary>
           /// Desc:检查内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SCORE_CONTECT {get;set;}

           /// <summary>
           /// Desc:评分标准
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SCORE_CRITERIA {get;set;}

           /// <summary>
           /// Desc:标准分
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? STANDARD_SCORE {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:修改人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:序号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SCORE_SORT {get;set;}

           /// <summary>
           /// Desc:检查依据
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BASIS {get;set;}

    }
}
