using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class TS_UIDP_USERINFO
    {
           public TS_UIDP_USERINFO(){


           }
           /// <summary>
           /// Desc:系统自动生成的用户唯一ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_ID {get;set;}

           /// <summary>
           /// Desc:员工编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_CODE {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_NAME {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_PASS {get;set;}

           /// <summary>
           /// Desc:0：男性；1：女性
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? USER_SEX {get;set;}

           /// <summary>
           /// Desc:手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PHONE_MOBILE {get;set;}

           /// <summary>
           /// Desc:办公电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PHONE_OFFICE {get;set;}

           /// <summary>
           /// Desc:用户邮箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_EMAIL {get;set;}

           /// <summary>
           /// Desc:注册时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? REG_TIME {get;set;}

           /// <summary>
           /// Desc:1：激活；0：未激活
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? FLAG {get;set;}

           /// <summary>
           /// Desc:账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_DOMAIN {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

           /// <summary>
           /// Desc:关联账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ASSOCIATED_ACCOUNT {get;set;}

           /// <summary>
           /// Desc:账号类型0本地 1ptr
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? AUTHENTICATION_TYPE {get;set;}

           /// <summary>
           /// Desc:用户类型(0:管理员1:普通用户)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? USER_TYPE {get;set;}

           /// <summary>
           /// Desc:ip
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USER_IP {get;set;}

    }
}
