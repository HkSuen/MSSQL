using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_RECEIVE
    {
           public EQ_INSPECT_RECEIVE(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:检查任务主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_ID {get;set;}

           /// <summary>
           /// Desc:角色编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ROLE_CODE {get;set;}

           /// <summary>
           /// Desc:被检查单位编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BJCDW_CODE {get;set;}

           /// <summary>
           /// Desc:接收状态STAT： 0默认未接收状态 1 接收状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? STAT {get;set;}

           /// <summary>
           /// Desc:确认接收人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:接收时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATEDATE {get;set;}

    }
}
