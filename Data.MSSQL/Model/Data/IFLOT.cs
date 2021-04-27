using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class IFLOT
    {
           public IFLOT(){


           }
           /// <summary>
           /// Desc:客户端 
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MANDT {get;set;}

           /// <summary>
           /// Desc:安装地点
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TPLNR {get;set;}

           /// <summary>
           /// Desc:对象文本的主要语言
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MLANG {get;set;}

           /// <summary>
           /// Desc:功能位置结构标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TPLKZ {get;set;}

           /// <summary>
           /// Desc:功能位置种类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FLTYP {get;set;}

           /// <summary>
           /// Desc:上一级功能位置 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TPLMA {get;set;}

           /// <summary>
           /// Desc:对象建立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ERDAT {get;set;}

           /// <summary>
           /// Desc:创建对象的用户名称 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ERNAM {get;set;}

           /// <summary>
           /// Desc:对象上次被修改的日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AEDAT {get;set;}

           /// <summary>
           /// Desc:最后修改对象的用户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AENAM {get;set;}

           /// <summary>
           /// Desc:转资日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DATAB {get;set;}

           /// <summary>
           /// Desc:技术对象授权组
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BEGRU {get;set;}

           /// <summary>
           /// Desc:参考功能位置 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TRPNR {get;set;}

           /// <summary>
           /// Desc:SAP 开发保留:格式字符,长度4
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PSTAE {get;set;}

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
           /// Desc:物资编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SUBMT {get;set;}

           /// <summary>
           /// Desc:制造类型字段的数据原点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SUBMTI {get;set;}

           /// <summary>
           /// Desc:制造商零件号 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MAPAR {get;set;}

           /// <summary>
           /// Desc:SAP 开发保留:格式字符,长度1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MAPARI {get;set;}

           /// <summary>
           /// Desc:在功能位置所允许的设备安装 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IEQUI {get;set;}

           /// <summary>
           /// Desc:允许设备安装字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IEQUII {get;set;}

           /// <summary>
           /// Desc:在功能位置安装设备 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EINZL {get;set;}

           /// <summary>
           /// Desc:授权组字段的数据原点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EINZLI {get;set;}

           /// <summary>
           /// Desc:维护计划工厂
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IWERK {get;set;}

           /// <summary>
           /// Desc:计划工厂字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IWERKI {get;set;}

           /// <summary>
           /// Desc:客户服务和工厂维护的计划员组
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INGRP {get;set;}

           /// <summary>
           /// Desc:维护计划员组字段的数据原点 
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
           public string LGWID {get;set;}

           /// <summary>
           /// Desc:字段‘工作中心’中的原始数据 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LGWIDI {get;set;}

           /// <summary>
           /// Desc:类别参数文件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RBNR {get;set;}

           /// <summary>
           /// Desc:维护目录字段的数据原点 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RBNR_I {get;set;}

           /// <summary>
           /// Desc:维护对象位置和科目分配 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ILOAN {get;set;}

           /// <summary>
           /// Desc:对象号 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OBJNR {get;set;}

           /// <summary>
           /// Desc:高级技术对象中位置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string POSNR {get;set;}

           /// <summary>
           /// Desc:工业(IS)解决的对象类型 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ISTYP {get;set;}

           /// <summary>
           /// Desc:前提
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PREMS {get;set;}

           /// <summary>
           /// Desc:设备编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQART {get;set;}

           /// <summary>
           /// Desc:资产编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INVNR {get;set;}

           /// <summary>
           /// Desc:大小/尺寸
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GROES {get;set;}

           /// <summary>
           /// Desc:毛重
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? BRGEW {get;set;}

           /// <summary>
           /// Desc:重量单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string GEWEI {get;set;}

           /// <summary>
           /// Desc:资产原值 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public double? ANSWT {get;set;}

           /// <summary>
           /// Desc:货币码 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WAERS {get;set;}

           /// <summary>
           /// Desc:购置日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ANSDT {get;set;}

           /// <summary>
           /// Desc:资产制造商
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HERST {get;set;}

           /// <summary>
           /// Desc:制造国别 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HERLD {get;set;}

           /// <summary>
           /// Desc:出厂年月
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BAUJJ {get;set;}

           /// <summary>
           /// Desc:施工月份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BAUMM {get;set;}

           /// <summary>
           /// Desc:规格型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TYPBZ {get;set;}

           /// <summary>
           /// Desc:按照制造商零件编号的物料编号 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EMATN {get;set;}

           /// <summary>
           /// Desc:出厂编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SERGE {get;set;}

           /// <summary>
           /// Desc:SAP发展储备:日期段的集合(代码)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HANDLE {get;set;}

           /// <summary>
           /// Desc:SAP发展储备:集合日期段(模板)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TSEGTP {get;set;}

           /// <summary>
           /// Desc:安装地点名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLTXT {get;set;}

           /// <summary>
           /// Desc:标志:长文本存在 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KZLTX {get;set;}

           /// <summary>
           /// Desc:正文部分的主要语言标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KZMLA {get;set;}

           /// <summary>
           /// Desc:大写字母中功能位置的描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLTXU {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DLDATE {get;set;}

    }
}
