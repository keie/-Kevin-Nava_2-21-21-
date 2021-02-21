using System.Collections.Generic;
using ModelLayer;

namespace Logic.Interfaces
{
    public interface IPhotoAlbumLogic
    {
        public IEnumerable<PhotoAlbum> GetList();
    }
}