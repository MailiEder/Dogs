using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Dogs.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase()
        {
            _connectionString = String.Format("Server = {0}; Port = {1}; User Id = {2}; Password = {3}; Database = {4};", "localhost", "5432", "postgres", "yourpassword", "DogDb");
        }

        protected NpgsqlConnection GetNpgsqlConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }

    }
}
