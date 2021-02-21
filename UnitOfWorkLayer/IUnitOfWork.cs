using System;
using RepositoryLayer;

namespace UnitOfWorkLayer
{
    public interface IUnitOfWork
    {
        IUsersRepository IUsers { get; }
        
        IAlbumRepository IAlbum { get; }
        
        IPhotoAlbumRepository IPhotoAlbum { get; }
        
        IPhotoCommentsRepository IPhotoComments { get; }
    }
}