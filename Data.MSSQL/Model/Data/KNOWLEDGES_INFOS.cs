using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.MSSQL.Model.Data
{
    ///<summary>
    ///
    ///</summary>
    public partial class KNOWLEDGES_INFOS
    {
        public KNOWLEDGES_INFOS()
        {


        }
        /// <summary>
        /// Desc:标识
        /// Default:
        /// Nullable:False
        /// </summary>      
        [SqlSugar.SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string ID { get; set; }

        /// <summary>
        /// Desc:知识标题
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TITLE { get; set; }

        /// <summary>
        /// Desc:知识编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string K_NUMBER { get; set; }

        /// <summary>
        /// Desc:知识分类ID
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string K_CATEGORY_ID { get; set; }

        /// <summary>
        /// Desc:设备分类ID
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string E_CATEGORY_ID { get; set; }

        /// <summary>
        /// Desc:1:制定；2：发布
        /// Default:
        /// Nullable:True
        /// </summary>           
        public decimal? STATUS { get; set; }

        /// <summary>
        /// Desc:知识描述
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DESCRIPT { get; set; }

        /// <summary>
        /// Desc:创建单位
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ORG_CODE { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? CREATE_TIME { get; set; }

        /// <summary>
        /// Desc:创建人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CREATOR { get; set; }

        /// <summary>
        /// Desc:创建人名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CREATE_NAME { get; set; }

        /// <summary>
        /// Desc:更新时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? UPDATE_TIME { get; set; }

        /// <summary>
        /// Desc:更新人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string UPDATOR { get; set; }


        #region 映射问题不能使用子类
         
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public List<KNOWLEDGES_RELATIONS> LABELS { get; set; }

        #endregion

    }
}
