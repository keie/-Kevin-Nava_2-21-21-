using System;
using System.Collections.Generic;
using Logic.Interfaces;
using ModelLayer;
using UnitOfWorkLayer;

namespace Logic.Implementations
{
    public class PhotoAlbumLogic:IPhotoAlbumLogic
    {
        private IUnitOfWork _unitOfWork;

        public PhotoAlbumLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IEnumerable<PhotoAlbum> GetList()
        {
            try
            {
                return (_unitOfWork.IPhotoAlbum.GetList());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}