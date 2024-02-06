using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2.Utility
{
    internal class DBConnectionUtil
    {
        private static IConfiguration _iConfiguration;
        static DBConnectionUtil()
        {
            GetAppSettingsFile();
        }

        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _iConfiguration = builder.Build();
        }
        public static string GetConnectionString()
        {
            return _iConfiguration.GetConnectionString("LocalConnString");
        }
    }
}
