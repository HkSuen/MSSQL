using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQSTATE_A11_CUSTOM_CONF
    {
           public EQSTATE_A11_CUSTOM_CONF(){


           }
           /// <summary>
           /// Desc:唯一标识
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:设备编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUNR {get;set;}

           /// <summary>
           /// Desc:A11点位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TAGNAME {get;set;}

           /// <summary>
           /// Desc:A11点位描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DESCRIPTION {get;set;}

           /// <summary>
           /// Desc:A11取值字段
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string A11FILED {get;set;}

           /// <summary>
           /// Desc:单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORGCODE {get;set;}

           /// <summary>
           /// Desc:设备种类编码（0646）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART {get;set;}

           /// <summary>
           /// Desc:自定义字段编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

    }
}
