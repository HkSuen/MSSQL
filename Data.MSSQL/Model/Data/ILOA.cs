using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class ILOA
    {
           public ILOA(){


           }
           /// <summary>
           /// Desc:客户端 
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MANDT {get;set;}

           /// <summary>
           /// Desc:维护对象位置和科目分配 
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ILOAN {get;set;}

           /// <summary>
           /// Desc:安装地点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TPLNR {get;set;}

           /// <summary>
           /// Desc:ABC 标识用于技术对象 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABCKZ {get;set;}

           /// <summary>
           /// Desc:ABC 标识字段的数据源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABCKZI {get;set;}

           /// <summary>
           /// Desc:自编号 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQFNR {get;set;}

           /// <summary>
           /// Desc:分类字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQFNRI {get;set;}

           /// <summary>
           /// Desc:维护工厂
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SWERK {get;set;}

           /// <summary>
           /// Desc:维护工厂字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SWERKI {get;set;}

           /// <summary>
           /// Desc:维护对象的位置 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STORT {get;set;}

           /// <summary>
           /// Desc:位置字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STORTI {get;set;}

           /// <summary>
           /// Desc:责任人 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MSGRP {get;set;}

           /// <summary>
           /// Desc:房间号字段的数据原点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MSGRPI {get;set;}

           /// <summary>
           /// Desc:工厂区域
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BEBER {get;set;}

           /// <summary>
           /// Desc:工厂部分字段的数据原
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BEBERI {get;set;}

           /// <summary>
           /// Desc:CIM 资源的对象类型 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CR_OBJTY {get;set;}

           /// <summary>
           /// Desc:PP工作中心对象标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PPSID {get;set;}

           /// <summary>
           /// Desc:生产计划工作中心字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PPSIDI {get;set;}

           /// <summary>
           /// Desc:业务范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GSBER {get;set;}

           /// <summary>
           /// Desc:业务范围字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GSBERI {get;set;}

           /// <summary>
           /// Desc:控制范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KOKRS {get;set;}

           /// <summary>
           /// Desc:控制范围字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KOKRSI {get;set;}

           /// <summary>
           /// Desc:成本中心
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KOSTL {get;set;}

           /// <summary>
           /// Desc:成本中心字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KOSTLI {get;set;}

           /// <summary>
           /// Desc:工作分解结构元素 (WBS 元素)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PROID {get;set;}

           /// <summary>
           /// Desc:WBS 要素字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PROIDI {get;set;}

           /// <summary>
           /// Desc:公司代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BUKRS {get;set;}

           /// <summary>
           /// Desc:公司代码字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BUKRSI {get;set;}

           /// <summary>
           /// Desc:主资产号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ANLNR {get;set;}

           /// <summary>
           /// Desc:资产主号/ 子号字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ANLNRI {get;set;}

           /// <summary>
           /// Desc:资产次级编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ANLUN {get;set;}

           /// <summary>
           /// Desc:源数据标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ANLUNI {get;set;}

           /// <summary>
           /// Desc:长期订单号 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DAUFN {get;set;}

           /// <summary>
           /// Desc:标准订单号字段的数据原点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DAUFNI {get;set;}

           /// <summary>
           /// Desc:结算订单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AUFNR {get;set;}

           /// <summary>
           /// Desc:结算订单字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AUFNRI {get;set;}

           /// <summary>
           /// Desc:功能位置字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TPLNRI {get;set;}

           /// <summary>
           /// Desc:销售组织 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VKORG {get;set;}

           /// <summary>
           /// Desc:销售组织字段的数据原点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VKORGI {get;set;}

           /// <summary>
           /// Desc:分销渠道
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VTWEG {get;set;}

           /// <summary>
           /// Desc:分销渠道字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VTWEGI {get;set;}

           /// <summary>
           /// Desc:产品组 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SPART {get;set;}

           /// <summary>
           /// Desc:产品组字段的数据来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SPARTI {get;set;}

           /// <summary>
           /// Desc:地址号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ADRNR {get;set;}

           /// <summary>
           /// Desc:地址字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ADRNRI {get;set;}

           /// <summary>
           /// Desc:对象参考标识 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OWNER {get;set;}

           /// <summary>
           /// Desc:销售部门 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VKBUR {get;set;}

           /// <summary>
           /// Desc:销售组
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VKGRP {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DLDATE {get;set;}

    }
}
