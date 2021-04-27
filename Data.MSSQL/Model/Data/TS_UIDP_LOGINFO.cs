using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_UIDP_LOGINFO
    {
           public TS_UIDP_LOGINFO(){


           }
           /// <summary>
           /// Desc:访问时间 格式：yyyy-mm-dd:hh:mm:ss
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ACCESS_TIME {get;set;}

           /// <summary>
           /// Desc:用户id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_ID {get;set;}

           /// <summary>
           /// Desc:用户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_NAME {get;set;}

           /// <summary>
           /// Desc:ip
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IP_ADDR {get;set;}

           /// <summary>
           /// Desc:日志类型 API调用/异常/登录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? LOG_TYPE {get;set;}

           /// <summary>
           /// Desc:报警级别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? ALARM_LEVEL {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LOG_CONTENT {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

    }
}
