using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class Q_INSPECT_TMP_EQART
    {
           public Q_INSPECT_TMP_EQART(){


           }
           /// <summary>
           /// Desc:数据主键id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:模板主表主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_TMP_ID {get;set;}

           /// <summary>
           /// Desc:设备分类编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART {get;set;}

           /// <summary>
           /// Desc:设备分类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART_NAME {get;set;}

           /// <summary>
           /// Desc:设备分类型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART_XH {get;set;}

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

    }
}
