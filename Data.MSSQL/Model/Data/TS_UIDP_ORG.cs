using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_UIDP_ORG
    {
           public TS_UIDP_ORG(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_ID {get;set;}

           /// <summary>
           /// Desc:组织机构代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_CODE {get;set;}

           /// <summary>
           /// Desc:全称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_NAME {get;set;}

           /// <summary>
           /// Desc:简称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_SHORT_NAME {get;set;}

           /// <summary>
           /// Desc:父级code
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_CODE_UPPER {get;set;}

           /// <summary>
           /// Desc:是否有效 1有效0无效
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? ISINVALID {get;set;}

           /// <summary>
           /// Desc:是否删除 0删除 1 未删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? ISDELETE {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

           /// <summary>
           /// Desc:父ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_ID_UPPER {get;set;}

           /// <summary>
           /// Desc:单位CODE，对应库存地点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DW_CODE {get;set;}

    }
}
