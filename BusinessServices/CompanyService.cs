using AutoMapper;
using BusinessEntities;
using DataModel;
using DataModel.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessServices
{
    class CompanyService : ICompanyService
    {

        #region Private member variables.
        private readonly UnitOfWork _unitOfWork;
        #endregion

        #region Public constructor.
        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public CompanyService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion


        public BusinessEntities.CompanyEntity GetCompanyById(long companyId)
        {
            if (companyId == 0)
                return null;

            var company = _unitOfWork.CompanyRepository.Get(c => c.Id == companyId);

            if (company == null)
                return null;

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Company, CompanyEntity>();
            });
            var productModel = Mapper.Map<Company, CompanyEntity>(company);
            return productModel;


        }

        public IEnumerable<BusinessEntities.CompanyEntity> GetAllCompany()
        {
            var companies = _unitOfWork.CompanyRepository.GetAll().ToList();
            if (companies == null)
                return null;

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Company, CompanyEntity>();
            });
            return Mapper.Map<List<Company>, List<CompanyEntity>>(companies);

        }

        public long CreateCompany(BusinessEntities.CompanyEntity companyEntity)
        {
            using (var scope = new TransactionScope())
            {
                var company = new Company
                {
                    Name = companyEntity.Name,
                    Logo = companyEntity.Logo,
                    Alias = companyEntity.Alias,
                    RegistrationNo = companyEntity.RegistrationNo,
                    CreatedBy = "SuperAdmin"
                };
                _unitOfWork.CompanyRepository.Insert(company);
                _unitOfWork.Save();
                scope.Complete();
                return company.Id;
            }
        }

        public bool UpdateCompany(long productId, BusinessEntities.CompanyEntity companyEntity)
        {
            using (var scope = new TransactionScope())
            {
                var company = new Company
                {
                    Name = companyEntity.Name,
                    Logo = companyEntity.Logo,
                    Alias = companyEntity.Alias,
                    RegistrationNo = companyEntity.RegistrationNo,
                    CreatedBy = "SuperAdmin"
                };
                _unitOfWork.CompanyRepository.Update(company);
                _unitOfWork.Save();
                scope.Complete();
                return true;
            }
        }

        public bool DeleteCompany(long productId)
        {
            throw new NotImplementedException();
        }
    }
}
