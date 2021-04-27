using SqlSugar;

using System;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class CONVERT_EQMAIN
    {
        public CONVERT_EQMAIN(){


           }
        /// <summary>
        /// Desc:设备编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] //是主键, 还是标识列
        public string EQUNR {get;set;}

           /// <summary>
           /// Desc:设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQKTX {get;set;}

           /// <summary>
           /// Desc:状态（删除等）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STTXT {get;set;}

           /// <summary>
           /// Desc:状态（在用等）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string STTXU {get;set;}

           /// <summary>
           /// Desc:设备种类（M 非安装,F 安装,S 客户）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EQTYP {get;set;}

           /// <summary>
           /// Desc:设备编码（0646-201）
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
           /// Desc:转资日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INBDT {get;set;}

           /// <summary>
           /// Desc:资产原值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ANSWT {get;set;}

           /// <summary>
           /// Desc:制造商
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HERST {get;set;}

           /// <summary>
           /// Desc:制造国家
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HERLD {get;set;}

           /// <summary>
           /// Desc:规格型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TYPBZ {get;set;}

           /// <summary>
           /// Desc:出厂编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SERGE {get;set;}

           /// <summary>
           /// Desc:维护工厂
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SWERK {get;set;}

           /// <summary>
           /// Desc:ABC标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ABCKZ {get;set;}

           /// <summary>
           /// Desc:公司代码（15C0）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BUKRS {get;set;}

           /// <summary>
           /// Desc:资产
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ANLNR {get;set;}

           /// <summary>
           /// Desc:成本中心
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KOSTL {get;set;}

           /// <summary>
           /// Desc:计划工厂
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IWERK {get;set;}

           /// <summary>
           /// Desc:计划人员组
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string INGRP {get;set;}

           /// <summary>
           /// Desc:维护中心
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WXZX {get;set;}

           /// <summary>
           /// Desc:安装地点
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PLTXT {get;set;}

           /// <summary>
           /// Desc:一保周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YB {get;set;}

           /// <summary>
           /// Desc:一保提醒期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YBTX {get;set;}

           /// <summary>
           /// Desc:二保周期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EB {get;set;}

           /// <summary>
           /// Desc:二保提醒期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EBTX {get;set;}

           /// <summary>
           /// Desc:主设备标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZZFSB {get;set;}

           /// <summary>
           /// Desc:主设备
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HEQUI {get;set;}

           /// <summary>
           /// Desc:主设备名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TXT_HEQUI {get;set;}

           /// <summary>
           /// Desc:特种设备
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZTSSB {get;set;}

           /// <summary>
           /// Desc:单位属性
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZDWSX {get;set;}

           /// <summary>
           /// Desc:设备类型说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZKTSCTXT {get;set;}

           /// <summary>
           /// Desc:计量单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZMEINS {get;set;}

           /// <summary>
           /// Desc:资产属性
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZZCSX {get;set;}

           /// <summary>
           /// Desc:效用年限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZXYNX {get;set;}

           /// <summary>
           /// Desc:残值率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZZCZL {get;set;}

           /// <summary>
           /// Desc:能力
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZZNL {get;set;}

           /// <summary>
           /// Desc:总功率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZZZGL {get;set;}

           /// <summary>
           /// Desc:能耗种类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZNHZL {get;set;}

           /// <summary>
           /// Desc:额定能耗
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZDENH {get;set;}

           /// <summary>
           /// Desc:投产日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZTCDATE {get;set;}

           /// <summary>
           /// Desc:负责人员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SGRNAM {get;set;}

           /// <summary>
           /// Desc:井号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZJH {get;set;}

           /// <summary>
           /// Desc:净资产值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZJZ {get;set;}

           /// <summary>
           /// Desc:车牌/井号描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZCPNO {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEDATE {get;set;}

           /// <summary>
           /// Desc:创建人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CREATEBY {get;set;}

           /// <summary>
           /// Desc:组织机构编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_CODE {get;set;}

           /// <summary>
           /// Desc:组织机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ORG_NAME {get;set;}

    }
}
