using Data.MSSQL.Common;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL
{
    public class Config
    {
        public static string ConnectionString => JsonReader.Get("ConnectionString");//必填, 数据库连接字符串
        public static DbType dbType => DbType.Oracle; //必填, 数据库类型
        public static bool isAutoCloseConection => true;//默认false的时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
        public static InitKeyType initKeyTyp => InitKeyType.SystemTable; //默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
        public static bool PrintSql = true;
    }
}
