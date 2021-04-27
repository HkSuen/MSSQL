using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQ_INSPECT_GROUP_DETAIL
    {
           public EQ_INSPECT_GROUP_DETAIL(){


           }
           /// <summary>
           /// Desc: 数据主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:检查小组ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INS_GROUP_ID {get;set;}

           /// <summary>
           /// Desc:检查人编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USERID {get;set;}

           /// <summary>
           /// Desc:检查人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USERNAME {get;set;}

           /// <summary>
           /// Desc:1:责任人 0：非责任人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public short? DUTY {get;set;}

    }
}
