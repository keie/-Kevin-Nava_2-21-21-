using System;
using RepositoryLayer;

namespace UnitOfWorkLayer
{
    public interface IUnitOfWork
    {
       
        
        IAlbumRepository IAlbum { get; }
        
        IPhotoAlbumRepository IPhotoAlbum { get; }
        
        IPhotoCommentsRepository IPhotoComments { get; }
    }
}