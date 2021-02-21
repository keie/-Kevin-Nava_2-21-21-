using System;
using System.Collections.Generic;
using Logic.Interfaces;
using ModelLayer;
using UnitOfWorkLayer;

namespace Logic.Implementations
{
    public class UsersLogic:IUsersLogic
    {
        private IUnitOfWork _unitOfWork;
        public UsersLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Users> GetLsit()
        {
            try
            {
                return (_unitOfWork.IUsers.GetList());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}