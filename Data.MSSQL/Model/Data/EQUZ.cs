using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class EQUZ
    {
           public EQUZ(){


           }
           /// <summary>
           /// Desc:客户端 
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MANDT {get;set;}

           /// <summary>
           /// Desc:设备编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EQUNR {get;set;}

           /// <summary>
           /// Desc:有效截至日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string DATBI {get;set;}

           /// <summary>
           /// Desc:同一天的设备使用期段连号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string EQLFN {get;set;}

           /// <summary>
           /// Desc:在同一天的下一个设备使用期间号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQUZN {get;set;}

           /// <summary>
           /// Desc:记录的创建日期 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ERDAT {get;set;}

           /// <summary>
           /// Desc:创建对象的人员名称 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ERNAM {get;set;}

           /// <summary>
           /// Desc:更改日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AEDAT {get;set;}

           /// <summary>
           /// Desc:对象更改人员的名称 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AENAM {get;set;}

           /// <summary>
           /// Desc:设备使用期间时间印记
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TIMBI {get;set;}

           /// <summary>
           /// Desc:SAP 开发保留:格式字符,长度1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ESTAI {get;set;}

           /// <summary>
           /// Desc:SAP 开发保留:格式字符,长度4
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ESTAE {get;set;}

           /// <summary>
           /// Desc:SAP 开发保留:格式字符,长度12
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STNAM {get;set;}

           /// <summary>
           /// Desc:SAP 开发保留:格式字符,长度1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LVORM {get;set;}

           /// <summary>
           /// Desc:开始生效日期 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DATAB {get;set;}

           /// <summary>
           /// Desc:维护计划工厂
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IWERK {get;set;}

           /// <summary>
           /// Desc:源数据标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IWERKI {get;set;}

           /// <summary>
           /// Desc:物资编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SUBMT {get;set;}

           /// <summary>
           /// Desc:制造商零件号 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MAPAR {get;set;}

           /// <summary>
           /// Desc:主设备 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HEQUI {get;set;}

           /// <summary>
           /// Desc:安装中设备位置（高级设备/功能位置） 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HEQNR {get;set;}

           /// <summary>
           /// Desc:客户服务和工厂维护的计划员组
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INGRP {get;set;}

           /// <summary>
           /// Desc:源数据标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INGRPI {get;set;}

           /// <summary>
           /// Desc:工作中心 CIM 资源的对象类型 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PM_OBJTY {get;set;}

           /// <summary>
           /// Desc:工作中心的对象标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GEWRK {get;set;}

           /// <summary>
           /// Desc:源数据标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GEWRKI {get;set;}

           /// <summary>
           /// Desc:技术标识号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TIDNR {get;set;}

           /// <summary>
           /// Desc:源数据标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TIDNRI {get;set;}

           /// <summary>
           /// Desc:维护对象位置和科目分配 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ILOAN {get;set;}

           /// <summary>
           /// Desc:客户号 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KUND1 {get;set;}

           /// <summary>
           /// Desc:最终客户号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KUND2 {get;set;}

           /// <summary>
           /// Desc:操作者 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KUND3 {get;set;}

           /// <summary>
           /// Desc:设备许可证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LIZNR {get;set;}

           /// <summary>
           /// Desc:类别参数文件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RBNR {get;set;}

           /// <summary>
           /// Desc:日期,供SAP内部使用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EZDAT {get;set;}

           /// <summary>
           /// Desc:技术信息,供SAP内部使用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EZBER {get;set;}

           /// <summary>
           /// Desc:数字字段,供SAP内部使用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EZNUM {get;set;}

           /// <summary>
           /// Desc:源数据标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RBNR_I {get;set;}

           /// <summary>
           /// Desc:库存盘点凭证
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IBLNR {get;set;}

           /// <summary>
           /// Desc:凭证中的凭证日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BLDAT {get;set;}

           /// <summary>
           /// Desc:PVS 对象的内部标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PVS_FOCUS {get;set;}

           /// <summary>
           /// Desc:PVS 对象的内部标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PPEGUID {get;set;}

           /// <summary>
           /// Desc:参数变式/标准变式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TECHS {get;set;}

           /// <summary>
           /// Desc:FID (功能标识)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FUNCID {get;set;}

           /// <summary>
           /// Desc:标识：强制安装/拆除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRCFIT {get;set;}

           /// <summary>
           /// Desc:强制拆除标记
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRCRMV {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DLDATE {get;set;}

    }
}
