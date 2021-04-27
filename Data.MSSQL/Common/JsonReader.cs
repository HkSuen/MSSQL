using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.MSSQL.Common
{


    public class JsonReader
    {
        private static IConfiguration _configuration = null;
        public static void Init()
        {
            if (_configuration == null)
            {
                var _builder = new ConfigurationBuilder();
                _configuration  = _builder.Add(new JsonConfigurationSource { Path = "App.json", Optional = false, ReloadOnChange = true }).Build();
            }
        }
        public static string Get(string key)
        {
            Init();
            IConfigurationSection value = _configuration.GetSection(key);
            return value.Value;
        }
    }
}
