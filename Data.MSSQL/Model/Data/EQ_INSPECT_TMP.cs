using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_TMP
    {
           public EQ_INSPECT_TMP(){


           }
           /// <summary>
           /// Desc:数据主键id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:模板编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_TMP_CODE {get;set;}

           /// <summary>
           /// Desc:模板名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_TMP_NAME {get;set;}

           /// <summary>
           /// Desc:说明内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_TMP_REMARK {get;set;}

           /// <summary>
           /// Desc:模板分类编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_EMP_CATEGORY_CODE {get;set;}

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
