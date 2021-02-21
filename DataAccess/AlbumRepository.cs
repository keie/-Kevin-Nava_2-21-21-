using ModelLayer;
using RepositoryLayer;

namespace DataAccess
{
    public class AlbumRepository:Repository<Album>,IAlbumRepository
    {
        public AlbumRepository(string connectionString):base(connectionString)
        {
            
        }
    }
}