using System.Collections.Generic;
using ModelLayer;

namespace Logic.Interfaces
{
    public interface IUsersLogic
    {
        public IEnumerable<Users> GetLsit();
    }
}