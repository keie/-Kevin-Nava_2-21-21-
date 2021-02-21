using System;
using System.Collections.Generic;
using Logic.Interfaces;
using ModelLayer;
using UnitOfWorkLayer;

namespace Logic.Implementations
{
    public class PhotoCommentsLogic:IPhotoCommentsLogic
    {
        private IUnitOfWork _unitOfWork;

        public PhotoCommentsLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public IEnumerable<PhotoComments> GetList()
        {
            try
            {
                return (_unitOfWork.IPhotoComments.GetList());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}