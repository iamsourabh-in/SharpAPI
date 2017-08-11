using DataModel.UnitOfWork;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BusinessServices
{
    public class AuthorizeService : IAuthorizeService
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public AuthorizeService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // Access Authorizer
        public bool AuthorizeAccess(string token, string actionOn, string actionType)
        {
            if (String.IsNullOrEmpty(token) || String.IsNullOrEmpty(actionOn) || String.IsNullOrEmpty(actionType)) return false;

            long empId = _unitOfWork.TokenRepository.Get(t => t.AuthToken == token).EmpId;

            SqlParameter[] parameters = new SqlParameter[3] { 
                new SqlParameter("@Token",token),
                new SqlParameter("@ActionOn", actionOn),
                new SqlParameter("@ActionType", actionType)
            };
            List<Permission> permissions = _unitOfWork.ExecWithStoreProcedure<Permission>("EXEC IsTokenAuthorised @Token, @ActionOn, @ActionType", parameters).ToList();

            if (permissions.Count() <= 0) return false; else return true;
        }
    }
}
