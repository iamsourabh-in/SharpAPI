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
    public class ProjectDocumentService : IProjectDocumentService
    {
        #region Private member variables.
        private readonly UnitOfWork _unitOfWork;
        #endregion

        #region Public constructor.
        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public ProjectDocumentService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        public BusinessEntities.ProjectDocumentEntity GetProjectDocumentById(long projectDocumentId)
        {
            if (projectDocumentId == 0)
                return null;

            var projectDocument = _unitOfWork.ProjectDocumentRepository.Get(p => p.Id == projectDocumentId);

            if (projectDocument == null)
                return null;

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ProjectDocument, ProjectDocumentEntity>();
            });
            var projectDocumentModel = Mapper.Map<ProjectDocument, ProjectDocumentEntity>(projectDocument);
            return projectDocumentModel;
        }

        public IEnumerable<BusinessEntities.ProjectDocumentEntity> GetAllProjectDocuments(long projectId)
        {
            var projectDocuments = _unitOfWork.ProjectDocumentRepository.GetMany(p => p.ProjectId == projectId).ToList();
            if (projectDocuments == null)
                return null;

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ProjectDocument, ProjectDocumentEntity>();
            });
            return Mapper.Map<List<ProjectDocument>, List<ProjectDocumentEntity>>(projectDocuments);
        }

        public long AddProjectDocument(BusinessEntities.ProjectDocumentEntity projectDocumentEntity)
        {
            using (var scope = new TransactionScope())
            {
                var projectDocument = new ProjectDocument
                {
                    FileName = projectDocumentEntity.FileName,
                    FileXtention = projectDocumentEntity.FileXtention,
                    Data = projectDocumentEntity.Data,
                    ProjectId = projectDocumentEntity.ProjectId,
                    Note = projectDocumentEntity.Note,
                    Created = DateTime.Now,
                    CreatedBy = projectDocumentEntity.CreatedBy,
                    Modified = DateTime.Now,
                    OwnerEmpID = projectDocumentEntity.OwnerEmpID,
                    Rejected = false

                };
                _unitOfWork.ProjectDocumentRepository.Insert(projectDocument);
                _unitOfWork.Save();
                scope.Complete();
                return projectDocument.Id;
            }
        }

        public bool UpdateProjectDocument(long projectDocumentId, BusinessEntities.ProjectDocumentEntity projectDocumentEntity)
        {
            using (var scope = new TransactionScope())
            {
                var company = new ProjectDocument
                {
                    FileName = projectDocumentEntity.FileName,
                    FileXtention = projectDocumentEntity.FileXtention,
                    Data = projectDocumentEntity.Data,
                    ProjectId = projectDocumentEntity.ProjectId,
                    Note = projectDocumentEntity.Note,
                    Created = DateTime.Now,
                    CreatedBy = projectDocumentEntity.CreatedBy,
                    Modified = DateTime.Now,
                    OwnerEmpID = projectDocumentEntity.OwnerEmpID,
                    Rejected = false
                };
                _unitOfWork.ProjectDocumentRepository.Update(company);
                _unitOfWork.Save();
                scope.Complete();
                return true;
            }
        }

        public bool DeleteProjectDocument(long projectDocumentId)
        {
            throw new NotImplementedException();
        }
    }
}
