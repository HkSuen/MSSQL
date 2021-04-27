using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_ZGFK
    {
           public EQ_INSPECT_ZGFK(){


           }
           /// <summary>
           /// Desc:数据主键id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:整改管理表主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZGGL_ID {get;set;}

           /// <summary>
           /// Desc:整改情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZGQK {get;set;}

           /// <summary>
           /// Desc:受检单位意见
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JCYJ {get;set;}

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
           /// Desc:反馈日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FKDATE {get;set;}

    }
}
