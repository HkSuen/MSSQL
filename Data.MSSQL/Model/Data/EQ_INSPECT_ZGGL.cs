using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_ZGGL
    {
           public EQ_INSPECT_ZGGL(){


           }
           /// <summary>
           /// Desc:数据主键id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:检查任务主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_ID {get;set;}

           /// <summary>
           /// Desc:被检查单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BJCDW_CODE {get;set;}

           /// <summary>
           /// Desc:接收人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USERID {get;set;}

           /// <summary>
           /// Desc:整改要求
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string JCJG {get;set;}

           /// <summary>
           /// Desc:限改时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string XGSJ {get;set;}

           /// <summary>
           /// Desc:创建单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYS_ORGCODE {get;set;}

           /// <summary>
           /// Desc:是否整改合格(0否1是)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IS_QUALIFIED {get;set;}

           /// <summary>
           /// Desc:状态 0新建状态 1下发状态 2已填写整改信息状态 3已反馈 4不同意 5 同意
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STAT {get;set;}

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
           /// Desc:修改人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEBY {get;set;}

           /// <summary>
           /// Desc:整改名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZGMC {get;set;}

           /// <summary>
           /// Desc:整改编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZG_CODE {get;set;}

    }
}
