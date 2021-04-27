using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class KNOWLEDGES_RELATIONS
    {
           public KNOWLEDGES_RELATIONS(){


           }
           /// <summary>
           /// Desc:标识
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ID {get;set;}

           /// <summary>
           /// Desc:知识库ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string INFO_ID {get;set;}

           /// <summary>
           /// Desc:标签ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LABEL_ID {get;set;}

    }
}
