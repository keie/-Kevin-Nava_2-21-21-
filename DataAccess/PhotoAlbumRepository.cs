using ModelLayer;
using RepositoryLayer;

namespace DataAccess
{
    public class PhotoAlbumRepository:Repository<PhotoAlbum>,IPhotoAlbumRepository
    {
        public PhotoAlbumRepository(string connectionString):base(connectionString)
        {
            
        }
    }
}