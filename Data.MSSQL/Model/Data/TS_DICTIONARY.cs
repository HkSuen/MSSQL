using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_DICTIONARY
    {
           public TS_DICTIONARY(){


           }
           /// <summary>
           /// Desc:系统id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string S_ID {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? S_CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string S_CREATEBY {get;set;}

           /// <summary>
           /// Desc:更新人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string S_UPDATEBY {get;set;}

           /// <summary>
           /// Desc:更新日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? S_UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:上级编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PARENTCODE {get;set;}

           /// <summary>
           /// Desc:编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CODE {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NAME {get;set;}

           /// <summary>
           /// Desc:英文字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ENGLISHCODE {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? SORTNO {get;set;}

    }
}
