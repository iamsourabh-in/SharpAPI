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
    class ProjectService : IProjectService
    {
        #region Private member variables.
        private readonly UnitOfWork _unitOfWork;
        #endregion

        #region Public constructor.
        /// <summary>  
        /// Public constructor.  
        /// </summary>  
        public ProjectService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region IProjectService Implementation.

        public BusinessEntities.ProjectEntity GetProjectById(long projectId)
        {
            if (projectId == 0)
                return null;

            var project = _unitOfWork.ProjectRepository.Get(c => c.Id == projectId);
            if (project == null)
                return null;

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Project, ProjectEntity>();
            });
            var projectModel = Mapper.Map<Project, ProjectEntity>(project);
            return projectModel;

        }

        public IEnumerable<BusinessEntities.ProjectEntity> GetAllProjects()
        {
            var projects = _unitOfWork.ProjectRepository.GetAll().ToList();
            if (projects == null)
                return null;

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Project, ProjectEntity>();
            });
            var projectModel = Mapper.Map<List<Project>, List<ProjectEntity>>(projects);
            return projectModel;
        }

        public long CreateProject(BusinessEntities.ProjectEntity projectEntity)
        {
            if (projectEntity == null)
                return 0;
            using (var scope = new TransactionScope())
            {
                var project = new Project
                {
                    Alias = projectEntity.Alias,
                    CompanyId = projectEntity.CompanyId,
                    Created = DateTime.Now,
                    CreatedBy = projectEntity.CreatedBy,
                    OwnerEmpId = projectEntity.OwnerEmpId,
                    Status = projectEntity.Status,
                    Name = projectEntity.Name,
                    Modified = DateTime.Now,
                    LeadId = projectEntity.LeadId,
                    Begin = DateTime.Now
                };
                _unitOfWork.ProjectRepository.Insert(project);
                _unitOfWork.Save();
                scope.Complete();
                return project.Id;
            }
        }

        public bool UpdateProject(long projectId, BusinessEntities.ProjectEntity projectEntity)
        {
            if (projectEntity == null)
                return false;
            using (var scope = new TransactionScope())
            {
                var project = new Project
                {
                    Alias = projectEntity.Alias,
                    CompanyId = projectEntity.CompanyId,
                    Created = projectEntity.Created,
                    CreatedBy = projectEntity.CreatedBy,
                    OwnerEmpId = projectEntity.OwnerEmpId,
                    Status = projectEntity.Status,
                    Name = projectEntity.Name,
                    Modified = DateTime.Now,
                    LeadId = projectEntity.LeadId,
                    Begin = projectEntity.Begin
                };
                _unitOfWork.ProjectRepository.Update(project);
                _unitOfWork.Save();
                scope.Complete();
                return true;
            }
        }

        public bool DeleteProject(long projectId)
        {
            _unitOfWork.ProjectRepository.Delete(c => c.Id == projectId);
            return true;
        }

        #endregion
    }
}
