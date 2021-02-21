using RepositoryLayer;
using UnitOfWorkLayer;

namespace DataAccess
{
    public class UnitOfWork: IUnitOfWork
    {
        public IUsersRepository IUsers { get;  }
        public IAlbumRepository IAlbum { get; }
        
        public IPhotoAlbumRepository IPhotoAlbum { get; }
        
        public IPhotoCommentsRepository IPhotoComments { get; }
        
        public UnitOfWork(string connectionString)
        {
            IUsers = new UsersRepository(connectionString);
            IAlbum = new AlbumRepository(connectionString);
            IPhotoAlbum = new PhotoAlbumRepository(connectionString);
            IPhotoComments = new PhotoCommentsRepository(connectionString);
        }
    }
}