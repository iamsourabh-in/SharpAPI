using DataModel.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Transactions;
using DataModel;
using BusinessEntities;
using AutoMapper;

namespace BusinessServices
{
    /// <summary>  
    /// Offers services for user specific operations  
    /// </summary>  
    public class UserServices : IUserServices
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public UserServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>  
        /// Public method to authenticate user by user name and word.  
        /// </summary>  
        /// <param name="userName"></param>  
        /// <param name="word"></param>  
        /// <returns></returns>  
        public int Authenticate(string email, string word)
        {
            var user = _unitOfWork.UserRepository.Get(u => u.Email == email && u.Password == u.Password);
            if (user != null && user.Id > 0)
            {
                return user.Id;
            }
            return 0;

        }


        public int CreateUser(BusinessEntities.UserEntity user)
        {
            using (var scope = new TransactionScope())
            {
                var newUser = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    Mobile = user.Mobile,
                    CreatedBy = "Registration"
                };
                _unitOfWork.UserRepository.Insert(newUser);
                _unitOfWork.Save();
                scope.Complete();
                return newUser.Id;
            }
        }


        public IEnumerable<BusinessEntities.UserEntity> GetAllUsers()
        {
            var users = _unitOfWork.UserRepository.GetAll().ToList();
            if (users.Any())
            {
                Mapper.Initialize(cfg =>
                   {
                       cfg.CreateMap<User, UserEntity>();
                   });
               
                var userModel = Mapper.Map<List<User>, List<UserEntity>>(users);
                return userModel;
            }
            return null;
        }

    }

}
