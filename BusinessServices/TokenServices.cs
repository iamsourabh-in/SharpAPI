using BusinessEntities;
using DataModel.UnitOfWork;
using System;
using System.Linq;
using System.Configuration;
using DataModel;

namespace BusinessServices
{
    public class TokenServices : ITokenServices
    {
        #region Private member variables.
        private readonly UnitOfWork _unitOfWork;
        #endregion

        #region Public constructor.
        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public TokenServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Public member methods.

        /// <summary>  
        /// Function to generate unique token with expiry against the provided userId.  
        /// Also add a record in database for generated token.  
        /// </summary>  
        /// <param name="userId"></param>  
        /// <returns></returns>  
        public TokenEntity GenerateToken(long employeeId)
        {
            string token = Guid.NewGuid().ToString();
            DateTime issuedOn = DateTime.Now;
            DateTime expiredOn = DateTime.Now.AddDays(Convert.ToDouble(ConfigurationManager.AppSettings["AuthTokenExpiry"]));
            var tokendomain = new Token
            {
                EmpId = employeeId,
                AuthToken = token,
                Created = issuedOn,
                Expiry = expiredOn
            };

            _unitOfWork.TokenRepository.Insert(tokendomain);
            _unitOfWork.Save();
            var tokenModel = new TokenEntity()
            {
                EmpId = employeeId,
                Created = issuedOn,
                Expiry = expiredOn,
                AuthToken = token
            };

            return tokenModel;
        }

        /// <summary>  
        /// Method to validate token against expiry and existence in database.  
        /// </summary>  
        /// <param name="tokenId"></param>  
        /// <returns></returns> 
        public bool ValidateToken(string tokenId)
        {
            var token = _unitOfWork.TokenRepository.Get(t => t.AuthToken == tokenId && t.Expiry > DateTime.Now);
            if (token != null && !(DateTime.Now > token.Expiry))
            {
                token.Expiry = token.Expiry.AddSeconds(
                Convert.ToDouble(ConfigurationManager.AppSettings["AuthTokenExpiry"]));
                _unitOfWork.TokenRepository.Update(token);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }

        public bool ExtendToken(string tokenId)
        {
            Token token = _unitOfWork.TokenRepository.Get(u => u.AuthToken == tokenId);
            token.Expiry = DateTime.Now.AddDays(1);
            _unitOfWork.TokenRepository.Update(token);
            _unitOfWork.Save();
            return true;
        }

        public bool Kill(string tokenId)
        {
            _unitOfWork.TokenRepository.Delete(x => x.AuthToken == tokenId);
            _unitOfWork.Save();
            var isNotDeleted = _unitOfWork.TokenRepository.GetMany(x => x.AuthToken == tokenId).Any();
            if (isNotDeleted)
            {
                return false;
            }
            return true;
        }

        public bool DeleteByUserId(int userId)
        {
            _unitOfWork.TokenRepository.Delete(x => x.EmpId == userId);
            _unitOfWork.Save();

            var isNotDeleted = _unitOfWork.TokenRepository.GetMany(x => x.EmpId == userId).Any();
            return !isNotDeleted;
        }

        #endregion
    }
}
