using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace EFDataLayer.Helpers
{
    public class ConnectionStringHelper
    {
        public static string HardCodedConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "EFCorePractice";
            builder.UserID = "sa";
            builder.Password = "sa";
            builder.IntegratedSecurity = false;

            return builder.ConnectionString;
        }

        public static string AppXmlConfigConnectionString()
        {
            return string.Empty;
        }

        public static string AppJsonConfigConnectionString()
        {
            return string.Empty;
        }
    }
}
