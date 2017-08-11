#region Using Namespaces...

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.Entity.Validation;
using DataModel.GenericRepository;

#endregion

namespace DataModel.UnitOfWork
{
    /// <summary>  
    /// Unit of Work class responsible for DB transactions  
    /// </summary>  
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        #region Private member variables...

        private WORKAHOLICdbEntities _context = null;
        private GenericRepository<Token> _tokenRepository;
        private GenericRepository<Employee> _employeeRepository;
        private GenericRepository<Company> _companyRepository;
        private GenericRepository<Role> _roleRepository;
        private GenericRepository<Permission> _permissionRepository;
        private GenericRepository<Lead> _leadRepository;
        private GenericRepository<LeadCommunication> _leadCommunicationRepository;
        private GenericRepository<CommunicationType> _communicationTypeRepository;
        private GenericRepository<Project> _projectRepository;
        private GenericRepository<ProjectDocument> _projectDocRepository;
        private GenericRepository<Team> _teamRepository;
        private GenericRepository<TeamMember> _teamMemberRepository;
        private GenericRepository<Epic> _epicRepository;
        private GenericRepository<EpicAuditLog> _epicAuditRepository;
        private GenericRepository<Feature> _featureRepository;
        private GenericRepository<FeatureAuditLog> _featureAuditRepository;
        private GenericRepository<Task> _taskRepository;
        private GenericRepository<TaskAuditLog> _taskAuditRepository;
        private GenericRepository<Status> _statusRepository;
        #endregion

        public UnitOfWork()
        {
            _context = new WORKAHOLICdbEntities();
        }

        #region Public Repository Creation properties...


        /// <summary>  
        /// Get/Set Property for Role repository.  
        /// </summary>  
        public GenericRepository<Role> RoleRepository
        {
            get
            {
                if (this._roleRepository == null)
                    this._roleRepository = new GenericRepository<Role>(_context);
                return _roleRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for Permission repository.  
        /// </summary>  
        public GenericRepository<Permission> PermissionRepository
        {
            get
            {
                if (this._permissionRepository == null)
                    this._permissionRepository = new GenericRepository<Permission>(_context);
                return _permissionRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for token repository.  
        /// </summary>  
        public GenericRepository<Token> TokenRepository
        {
            get
            {
                if (this._tokenRepository == null)
                    this._tokenRepository = new GenericRepository<Token>(_context);
                return _tokenRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for token repository.  
        /// </summary>  
        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {
                if (this._employeeRepository == null)
                    this._employeeRepository = new GenericRepository<Employee>(_context);
                return _employeeRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for Company repository.  
        /// </summary>  
        public GenericRepository<Company> CompanyRepository
        {
            get
            {
                if (this._companyRepository == null)
                    this._companyRepository = new GenericRepository<Company>(_context);
                return _companyRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for Lead repository.  
        /// </summary>  
        public GenericRepository<Lead> LeadRepository
        {
            get
            {
                if (this._leadRepository == null)
                    this._leadRepository = new GenericRepository<Lead>(_context);
                return _leadRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for LeadCommunication repository.  
        /// </summary>  
        public GenericRepository<LeadCommunication> LeadCommunicationRepository
        {
            get
            {
                if (this._leadCommunicationRepository == null)
                    this._leadCommunicationRepository = new GenericRepository<LeadCommunication>(_context);
                return _leadCommunicationRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for CommunicationType repository.  
        /// </summary>  
        public GenericRepository<CommunicationType> CommunicationTypeRepository
        {
            get
            {
                if (this._communicationTypeRepository == null)
                    this._communicationTypeRepository = new GenericRepository<CommunicationType>(_context);
                return _communicationTypeRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for Project
        /// </summary>  
        public GenericRepository<Project> ProjectRepository
        {
            get
            {
                if (this._projectRepository == null)
                    this._projectRepository = new GenericRepository<Project>(_context);
                return _projectRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for ProjectDocument Repository
        /// </summary>  
        public GenericRepository<ProjectDocument> ProjectDocumentRepository
        {
            get
            {
                if (this._projectDocRepository == null)
                    this._projectDocRepository = new GenericRepository<ProjectDocument>(_context);
                return _projectDocRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for Team repository.  
        /// </summary>  
        public GenericRepository<Team> TeamRepository
        {
            get
            {
                if (this._teamRepository == null)
                    this._teamRepository = new GenericRepository<Team>(_context);
                return _teamRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for TeamMember
        /// </summary>  
        public GenericRepository<TeamMember> TeamMemberRepository
        {
            get
            {
                if (this._teamMemberRepository == null)
                    this._teamMemberRepository = new GenericRepository<TeamMember>(_context);
                return _teamMemberRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for Epic
        /// </summary>  
        public GenericRepository<Epic> EpicRepository
        {
            get
            {
                if (this._epicRepository == null)
                    this._epicRepository = new GenericRepository<Epic>(_context);
                return _epicRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for EpicAuditLog 
        /// </summary>  
        public GenericRepository<EpicAuditLog> EpicAuditLogRepository
        {
            get
            {
                if (this._epicAuditRepository == null)
                    this._epicAuditRepository = new GenericRepository<EpicAuditLog>(_context);
                return _epicAuditRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for Feature 
        /// </summary>  
        public GenericRepository<Feature> FeatureRepository
        {
            get
            {
                if (this._featureRepository == null)
                    this._featureRepository = new GenericRepository<Feature>(_context);
                return _featureRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for FeatureAuditLog 
        /// </summary>  
        public GenericRepository<FeatureAuditLog> FeatureAuditLogRepository
        {
            get
            {
                if (this._featureAuditRepository == null)
                    this._featureAuditRepository = new GenericRepository<FeatureAuditLog>(_context);
                return _featureAuditRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for Task 
        /// </summary>  
        public GenericRepository<Task> TaskRepository
        {
            get
            {
                if (this._taskRepository == null)
                    this._taskRepository = new GenericRepository<Task>(_context);
                return _taskRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for TaskAuditLog 
        /// </summary>  
        public GenericRepository<TaskAuditLog> TaskAuditLogRepository
        {
            get
            {
                if (this._taskAuditRepository == null)
                    this._taskAuditRepository = new GenericRepository<TaskAuditLog>(_context);
                return _taskAuditRepository;
            }
        }

        /// <summary>  
        /// Get/Set Property for StatusRepository 
        /// </summary>  
        public GenericRepository<Status> StatusRepository
        {
            get
            {
                if (this._statusRepository == null)
                    this._statusRepository = new GenericRepository<Status>(_context);
                return _statusRepository;
            }
        }



        #endregion

        #region Public member methods...
        /// <summary>  
        /// Save method.  
        /// </summary>  
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format("{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>  
        /// Protected Virtual Dispose method  
        /// </summary>  
        /// <param name="disposing"></param>  
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>  
        /// Dispose method  
        /// </summary>  
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


        public IEnumerable<T> ExecWithStoreProcedure<T>(string sql, params object[] parameters)
        {
            return _context.Database.SqlQuery<T>(sql, parameters);
        }


    }
}