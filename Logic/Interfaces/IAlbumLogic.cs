using System.Collections.Generic;
using ModelLayer;
using ModelLayer.ResponseDTO;

namespace Logic.Interfaces
{
    public interface IAlbumLogic
    {
        public IEnumerable<AlbumResponseDTO> GetList();
    }
}