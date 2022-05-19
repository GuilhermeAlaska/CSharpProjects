using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace PlaylistProjectWithDatabase
{
    class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private bool isConnectionOpen = false;

        public Database()
        {
            InitializeConnection();
        }

        public void InitializeConnection()
        {
            server = "localhost";
            database = "newdatabase";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            connection.Open();
            isConnectionOpen = true;
            return true;
        }
        public bool CloseConnection()
        {
            connection.Close();
            isConnectionOpen = false;
            return true;
        }
        public void InsertInto(string name, string author, string genre)
        {
            string query = "insert into musiclibrary2(nome, author, genre) values('" + name + "', '" + author + "', '" + genre + "');";
            if (!isConnectionOpen)
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            else { Console.WriteLine("A conexão com o banco de dados está fechada."); }
        }
        public void Update(string columnToUpdate, string newValue, string referenceColumn, string referenceValueInTable)
        {
            string query;
            if (referenceColumn == "id")
            {
                query = $"update musiclibrary2 set {columnToUpdate}= '{newValue}' where {referenceColumn} = {Convert.ToInt32(referenceValueInTable)}";
                OpenConnection();
                MySqlCommand cmd = new(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
                Console.WriteLine("Update realizado com sucesso!");
            }
            else if (columnToUpdate == "nome" || columnToUpdate == "author" || columnToUpdate == "genre")
            {
                query = $"update musiclibrary2 set {columnToUpdate}= '{newValue}' where {referenceColumn} = '{referenceValueInTable}'";
                OpenConnection();
                MySqlCommand cmd = new(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
                Console.WriteLine("Update realizado com sucesso!");
            }
            else { Console.WriteLine("Field inválido para alteração."); }
        }
        public void Count()
        {
            string query = "select count(*) from musiclibrary2;";
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader result = cmd.ExecuteReader();
            result.Read();
            Console.Write(result["count(*)"]);
            CloseConnection();
        }
        public void SelectAll()
        {
            string query = "select * from musiclibrary2";
            MySqlCommand cmd = new(query, connection);
            if (!isConnectionOpen)
            {
                OpenConnection();
            }
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Console.WriteLine($"Id: {result["id"],1}\tnome: {result["nome"],-20}\tauthor: {result["author"],-20}\tgenre: {result["genre"]}");
                }
            }
            CloseConnection();
        }
    }
}
