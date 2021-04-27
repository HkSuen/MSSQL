using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class LOGINFO
    {
           public LOGINFO(){


           }
           /// <summary>
           /// Desc:编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LOG_CODE {get;set;}

           /// <summary>
           /// Desc:日志类型，0.接口下载，1.数据转换
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LOG_TYPE {get;set;}

           /// <summary>
           /// Desc:日志时间，发生时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LOG_DATEGET {get;set;}

           /// <summary>
           /// Desc:方案编号，接口编号，转化表编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLAN_CODE {get;set;}

           /// <summary>
           /// Desc:方案内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLAN_NAME {get;set;}

           /// <summary>
           /// Desc:获取或转化时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LOG_DATE {get;set;}

           /// <summary>
           /// Desc:具体的转化内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LOG_REMARK {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK1 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK2 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK3 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK4 {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK5 {get;set;}

    }
}
