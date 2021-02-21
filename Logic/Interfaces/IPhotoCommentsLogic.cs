using System.Collections.Generic;
using ModelLayer;

namespace Logic.Interfaces
{
    public interface IPhotoCommentsLogic
    {
        public IEnumerable<PhotoComments> GetList();
    }
}