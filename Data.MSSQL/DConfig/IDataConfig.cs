using Data.MSSQL.DConfig;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL
{
    public interface IDataConfig
    {
        /// <summary>
        /// //用来处理事务多表查询和复杂的操作,具有更加完整的实现方式
        /// </summary>
        SqlSugarClient Db();

        // <summary>
        /// 如果想使用Sql的方式来执行，可以使用Sql进行逻辑处理
        /// </summary>
        IAdo Sql();

        /// <summary>
        /// 针对当前实体类进行操作,具有增删改查的封装。
        /// </summary>
        DbSet<T> CurrentDb<T>() where T : class, new();
    }
}
