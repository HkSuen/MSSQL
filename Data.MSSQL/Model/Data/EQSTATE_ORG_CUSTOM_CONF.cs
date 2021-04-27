using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQSTATE_ORG_CUSTOM_CONF
    {
           public EQSTATE_ORG_CUSTOM_CONF(){


           }
           /// <summary>
           /// Desc:唯一标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORGCODE {get;set;}

           /// <summary>
           /// Desc:设备种类编码（0646-201）
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
           public string CREATEDATE {get;set;}

           /// <summary>
           /// Desc:修改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:修改人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

    }
}
