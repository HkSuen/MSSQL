using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL.DConfig
{
    /// <summary>
    /// 如需扩展SimpleClient，可以从类进行扩展
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DbSet<T> : SimpleClient<T> where T : class, new()
    {
        public DbSet(SqlSugarClient context) : base(context)
        {

        }
        //SimpleClient中的方法满足不了你，可以扩展自已的方法。案例：
        //public List<T> GetByIds(dynamic[] ids)
        //{
        //    return Context.Queryable<T>().In(ids).ToList(); ;
        //}
    }
}
