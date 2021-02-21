using ModelLayer;
using RepositoryLayer;

namespace DataAccess
{
    public class UsersRepository:Repository<Users>,IUsersRepository
    {
        public UsersRepository(string connectionString):base(connectionString)
        {
            
        }
    }
}