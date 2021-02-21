using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using RepositoryLayer;
using Dapper.Contrib.Extensions;
namespace DataAccess
{
    public class Repository<T>:IRepository<T> where T : class
    {
        protected string _connectionString;

        public Repository(string _connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"[{type.Name}]";};
            this._connectionString = _connectionString;
        }

        public bool Delete(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Delete(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Update(entity);
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public T GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Get<T>(id);
            }
        }
    }
}