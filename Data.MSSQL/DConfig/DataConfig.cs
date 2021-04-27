using Data.MSSQL.DConfig;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Data.MSSQL
{
    /// <summary>
    /// Content ：http://www.codeisbug.com/Doc/8/1151 
    /// 注意事项：
    ///  1.非公用的方法禁止，从本类进行扩展。扩展前必须从IDataConfig声明对应的逻辑名称
    ///  2.如果不满足业务上的处理要求或特殊需要可以重写DbContext中默认 增、删、查、改、方法 
    /// </summary>
    public class DataConfig : IDataConfig
    {
        private static DataConfig _this = new DataConfig();
        #region Private 不需要看这里，折叠起来就可以
        private static SqlSugarClient _db
        {   //不同的线程就是不同的实例事务
            get => DataBase(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString,//必填, 数据库连接字符串
                DbType = Config.dbType,      //必填, 数据库类型,切库的时候，这里也需要进行更改。
                IsAutoCloseConnection = Config.isAutoCloseConection,       //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                InitKeyType = Config.initKeyTyp    //默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
            });
        }

        public static DataConfig GetThis() => _this;

        public static SqlSugarClient DataBase(ConnectionConfig SqlConnection)
        {
            SqlSugarClient sqlSugarClient = new SqlSugarClient(SqlConnection);
            sqlSugarClient.Aop.OnLogExecuting = (sql, pars) =>
            {
                if (Config.PrintSql)
                   Console.WriteLine(sql);
            };
            return sqlSugarClient;
        }

        public static void Model(string Path,string Space)
        {
            _db.DbFirst.CreateClassFile(Path, Space);
        }

        #endregion

        /// <summary>
        /// 如果想使用Sql的方式来执行，可以使用Sql进行逻辑处理
        /// </summary>
        public IAdo Sql() => _db.Ado;
        public static IAdo ExcuteSql() => _db.Ado;

        /// <summary>
        /// 用来处理事务多表查询和复杂的操作 （或扩展公用）
        /// 也可以在自己单独类里进行复杂的逻辑
        /// </summary>
        public SqlSugarClient Db() => _db;
        public static SqlSugarClient ExcuteDB() => _db;

        /// <summary>
        /// 基本操作的直接调用本方法即可，有封装的基本方法:增删改查、翻页等
        /// 如果扩展公用的方法，移步到DbSet 进行扩展.
        /// </summary>
        public DbSet<T> CurrentDb<T>() where T:class,new()
        { 
            return new DbSet<T>(_db);
        }//用来处理T表的常用操作

        public static DbSet<T> ExcuteDBSET<T>() where T : class, new() => new DbSet<T>(_db);

    }

}
