
using MySql.Data.MySqlClient;

namespace UnderstandWindownsForms.config_db {

    internal class ConnectToMysql {

        private MySqlConnection mySqlConnection;

        // order it does not importance
        private readonly string infoConnect = "SERVER=localhost;" +
                                              "UID=ttknp;" +
                                              "PASSWORD=12345;" +
                                              "DATABASE=it_shop";

        public ConnectToMysql() {
            mySqlConnection = new MySqlConnection(infoConnect); // if This class was create ** mySqlConnection already to use
        }

        public MySqlConnection MySqlConnection {
            get => mySqlConnection;
        }
    }
}