using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IHttpContextAccessor _httpContextAccessor;
        public UserManager(IUserDal userDal, IHttpContextAccessor httpContextAccessor)
        {
            _userDal = userDal;
            _httpContextAccessor = httpContextAccessor;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
