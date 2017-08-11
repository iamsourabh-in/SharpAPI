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
    class LeadService : ILeadService
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public LeadService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Implementating Interface


        public BusinessEntities.LeadEntity GetLeadById(long leadId)
        {
            var lead = _unitOfWork.LeadRepository.Get(l => l.Id == leadId);
            if (lead != null)
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Lead, LeadEntity>();
                });

                var leadModel = Mapper.Map<Lead, LeadEntity>(lead);
                return leadModel;
            }
            return null;

        }

        public IEnumerable<BusinessEntities.LeadEntity> GetAllLeads()
        {
            var leads = _unitOfWork.LeadRepository.GetAll().ToList();
            if (leads != null)
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Lead, LeadEntity>();
                });

                var leadsModel = Mapper.Map<List<Lead>, List<LeadEntity>>(leads);
                return leadsModel;
            }
            return null;
        }

        public long CreateLead(BusinessEntities.LeadEntity leadEntity)
        {
            using (var scope = new TransactionScope())
            {
                var newLead = new Lead
                {
                    CompanyId = leadEntity.CompanyId,
                    FirstName = leadEntity.FirstName,
                    LastName = leadEntity.LastName,
                    DOB = leadEntity.DOB,
                    Alias = leadEntity.Alias,
                    OwnerEmpID = leadEntity.OwnerEmpID,
                    Created = DateTime.Now,
                    CreatedBy = leadEntity.CreatedBy,

                };
                _unitOfWork.LeadRepository.Insert(newLead);
                _unitOfWork.Save();
                scope.Complete();
                return newLead.Id;
            }
        }

        public bool UpdateLead(long leadId, BusinessEntities.LeadEntity leadEntity)
        {
            using (var scope = new TransactionScope())
            {
                var newLead = new Lead
                {
                    CompanyId = leadEntity.CompanyId,
                    FirstName = leadEntity.FirstName,
                    LastName = leadEntity.LastName,
                    DOB = leadEntity.DOB,
                    Alias = leadEntity.Alias,
                    OwnerEmpID = leadEntity.OwnerEmpID,
                    Created = DateTime.Now,
                    CreatedBy = leadEntity.CreatedBy,

                };
                _unitOfWork.LeadRepository.Insert(newLead);
                _unitOfWork.Save();
                scope.Complete();
                return true;
            }
        }

        public bool DeleteLead(long leadId)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
