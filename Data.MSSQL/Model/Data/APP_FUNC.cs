using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class APP_FUNC
    {
           public APP_FUNC(){


           }
           /// <summary>
           /// Desc:功能ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FUNCID {get;set;}

           /// <summary>
           /// Desc:功能编码，2位组合，例01，01
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FUNCCODE {get;set;}

           /// <summary>
           /// Desc:功能名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FUNCNAME {get;set;}

           /// <summary>
           /// Desc:父功能编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? PARENTCODE {get;set;}

           /// <summary>
           /// Desc:类型，0=管理类,1=业务类 2=报表类 3=服务类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? FUNCTYPE {get;set;}

           /// <summary>
           /// Desc:URL地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FUNCURL {get;set;}

           /// <summary>
           /// Desc:是否按钮，0=菜单,1=按钮
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BUTTONFLAG {get;set;}

           /// <summary>
           /// Desc:是否有效，0=无效,1=有效（预留）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ENABLED {get;set;}

           /// <summary>
           /// Desc:标志（预留）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MARKCURRENCY {get;set;}

           /// <summary>
           /// Desc:表名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TAB {get;set;}

           /// <summary>
           /// Desc:图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ICON {get;set;}

           /// <summary>
           /// Desc:级别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MARKLEVEL {get;set;}

           /// <summary>
           /// Desc:是否明细，0=否,1=是
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? MARKTAIL {get;set;}

           /// <summary>
           /// Desc:同级序号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? SEQ {get;set;}

           /// <summary>
           /// Desc:路径，例如基础管理/用户组织管理/用户管理
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PATHNAME {get;set;}

           /// <summary>
           /// Desc:显示到菜单，0=不显示,1=显示
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ISDISPLAYINMENU {get;set;}

           /// <summary>
           /// Desc:默认打开，0=不打开,1=打开
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ISOPEN {get;set;}

           /// <summary>
           /// Desc:生成方式(0固定页面，1固定与动态结合，2动态页面，3动态(含业务))
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEMODE {get;set;}

           /// <summary>
           /// Desc:操作方式，1:表格直接编辑  2:卡片弹出式编辑
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? OPERATIONMODE {get;set;}

           /// <summary>
           /// Desc:虚拟单位是否显示 （预留）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? VIRTUAL {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string REMARK {get;set;}

           /// <summary>
           /// Desc:是否记录日志标志，1=记录,0=不记录
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? LOGFLAG {get;set;}

           /// <summary>
           /// Desc:是否调用数据权限，0=不调用,1=调用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ISCALLDATAPERMISSION {get;set;}

           /// <summary>
           /// Desc:子系统ID（预留）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? SYSTEMID {get;set;}

           /// <summary>
           /// Desc:建立人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATORID {get;set;}

           /// <summary>
           /// Desc:建立人名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATORNAME {get;set;}

           /// <summary>
           /// Desc:建立时间，yyyy-MM-dd hh:mm:ss
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATETIME {get;set;}

           /// <summary>
           /// Desc:修改人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATEID {get;set;}

           /// <summary>
           /// Desc:修改人名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATENAME {get;set;}

           /// <summary>
           /// Desc:修改时间，yyyy-MM-dd hh:mm:ss
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UPDATETIME {get;set;}

           /// <summary>
           /// Desc:虚拟单位是否显示 （预留）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? VIRTUAL0 {get;set;}

    }
}
