using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQMAIN_CUSTOM_CONF
    {
           public EQMAIN_CUSTOM_CONF(){


           }
           /// <summary>
           /// Desc:主键 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:设备编码选择 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART {get;set;}

           /// <summary>
           /// Desc:字段编码下来选择
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_CODE {get;set;}

           /// <summary>
           /// Desc:字段标识，手工录入 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_TYPE {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEDATE {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEDATE {get;set;}

           /// <summary>
           /// Desc:
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

           /// <summary>
           /// Desc:定义字段lab名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_NAME {get;set;}

           /// <summary>
           /// Desc:系统单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYS_ORG_CODE {get;set;}

           /// <summary>
           /// Desc:erp单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ERP_ORG_CODE {get;set;}

           /// <summary>
           /// Desc:设备种类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART_NAME {get;set;}

           /// <summary>
           /// Desc:用户定义的字段名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FILED_ZDY_NAME {get;set;}

    }
}
