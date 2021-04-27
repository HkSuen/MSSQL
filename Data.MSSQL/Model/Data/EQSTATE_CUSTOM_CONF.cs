using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQSTATE_CUSTOM_CONF
    {
           public EQSTATE_CUSTOM_CONF(){


           }
           /// <summary>
           /// Desc:唯一标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:设备种类编码（0646-201）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART {get;set;}

           /// <summary>
           /// Desc:用户定义字段名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART_EQNAME {get;set;}

           /// <summary>
           /// Desc:自定义字段编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED {get;set;}

           /// <summary>
           /// Desc:自定义字段标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_TYPE {get;set;}

           /// <summary>
           /// Desc:高预警值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_GYJ {get;set;}

           /// <summary>
           /// Desc:低预警值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_DYJ {get;set;}

           /// <summary>
           /// Desc:自定义字段单位，暂时不用，以后扩展用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_ORGCODE {get;set;}

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

           /// <summary>
           /// Desc:设备种类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART_NAME {get;set;}

           /// <summary>
           /// Desc:系统自定义字段名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_NAME {get;set;}

           /// <summary>
           /// Desc:用户定义计量单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_JLDW {get;set;}

    }
}
