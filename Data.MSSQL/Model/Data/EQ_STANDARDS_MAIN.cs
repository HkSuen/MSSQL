using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_STANDARDS_MAIN
    {
           public EQ_STANDARDS_MAIN(){


           }
           /// <summary>
           /// Desc:规程ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:规程编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STANDARDS_NUMBER {get;set;}

           /// <summary>
           /// Desc:规程所属单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STANDARDS_ORGCODE {get;set;}

           /// <summary>
           /// Desc:规程名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STANDARDS_NAME {get;set;}

           /// <summary>
           /// Desc:规程内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STANDARDS_CONTENT {get;set;}

           /// <summary>
           /// Desc:规程状态 0新建 1发布 2已过期 3作废
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STANDARDS_STATE {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

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
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:规程分类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STANDARDS_TYPE {get;set;}

           /// <summary>
           /// Desc:有效期 年
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? STANDARDS_YEAR {get;set;}

           /// <summary>
           /// Desc:有效期 月
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? STANDARDS_MONTH {get;set;}

           /// <summary>
           /// Desc:有效期 日
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? STANDARDS_DAY {get;set;}

    }
}
