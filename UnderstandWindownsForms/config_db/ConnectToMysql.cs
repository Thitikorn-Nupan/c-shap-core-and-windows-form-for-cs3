using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UnderstandWindownsForms.config_db
{
    internal class ConnectToMysql
    {
        private MySqlConnection mySqlConnection;
        // order it does not importance 
        private readonly string infoConnect = "SERVER=localhost;" +
                                              "UID=ttknp;" +
                                              "PASSWORD=12345;" +
                                              "DATABASE=it_shop";
        public ConnectToMysql()
        {
            // prepare mysql connect attributes 
            mySqlConnection = new MySqlConnection(infoConnect);
        }

        public MySqlConnection MySqlConnection
        {
            get => mySqlConnection;
        }



    }
}
