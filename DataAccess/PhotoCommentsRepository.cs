using ModelLayer;
using RepositoryLayer;

namespace DataAccess
{
    public class PhotoCommentsRepository:Repository<PhotoComments>,IPhotoCommentsRepository
    {
        public PhotoCommentsRepository(string connectionString):base(connectionString)
        {
            
        }
    }
}