using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UnderstandWindownsForms.config_db;
using UnderstandWindownsForms.entities;
using UnderstandWindownsForms.repository;

namespace UnderstandWindownsForms.sevices
{
    internal class MobileService : ObjectRepo<Mobile>
    {
        private ConnectToMysql connectToMysql;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private readonly string[] SQL_COMMAND =
        {
            "select * from mobiles",
            "insert into mobiles values(@mbid,@model,@brand,@price,@amount)",
            "select * from mobiles where mbid = @mbid",
            "delete from mobiles where mbid = @mbid",

        };
        public MobileService()
        {
            connectToMysql = new ConnectToMysql();
            connection = connectToMysql.MySqlConnection;
            // ** init object before take the sql DLC
            command = new MySqlCommand();
        }

        public List<Mobile> getObjects()
        {
            List<Mobile> mobiles = new List<Mobile>();
            // connect mysql
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[0];
            // ExecuteReader() Used to execute a command that will return 0 or more 
            reader = command.ExecuteReader();
            // Read the data and store them in the list
            while (reader.Read())
            {
                Mobile mobile = new Mobile(
                    (string)reader["mbid"],
                    (string)reader["model"],
                    (string)reader["brand"],
                    Convert.ToDouble(reader["price"]),
                    (int)Convert.ToInt64(reader["amount"])
                );
                mobiles.Add(mobile);
            }
            reader.Close();
            connection.Close();
            return mobiles;
        }

        public Mobile getObject(string mbid)
        {
            Console.WriteLine(mbid);
            Mobile mobile = null;
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[2];
            command.Parameters.AddWithValue("@mbid", mbid);
            
            reader = command.ExecuteReader();
            // Read the data and store them in the list
            while (reader.Read())
            {
                mobile = new Mobile(
                    (string)reader["mbid"],
                    (string)reader["model"],
                    (string)reader["brand"],
                    Convert.ToDouble(reader["price"]),
                    (int)Convert.ToInt64(reader["amount"])
                );
            }
            command.Parameters.Clear(); // have to clear params if you used as a loop 
            reader.Close();
            connection.Close();
            return mobile;
        }

        public bool addObject(Mobile obj)
        {
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[1];
            command.Parameters.AddWithValue("@mbid", obj.Mbid);
            command.Parameters.AddWithValue("@model", obj.Model);
            command.Parameters.AddWithValue("@brand", obj.Brand);
            command.Parameters.AddWithValue("@price", obj.Price);
            command.Parameters.AddWithValue("@amount", obj.Amount);
            int resultQuery = command.ExecuteNonQuery();
            connection.Close(); // always  close
            if (resultQuery != 0)
            {
                return true;
            }
            return false;
        }

        public bool removeObject(string mbid)
        {
            connection.Open();
            // set up command for query
            command.Connection = connection;
            command.CommandText = SQL_COMMAND[3];
            command.Parameters.AddWithValue("@mbid", mbid);
            int resultQuery = command.ExecuteNonQuery();
            connection.Close(); // always  close
            command.Parameters.Clear();
            if (resultQuery != 0)
            {
                return true;
            }
            return false;
        }
    }
}
