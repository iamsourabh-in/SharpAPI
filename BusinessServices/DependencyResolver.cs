using System.ComponentModel.Composition;
using BusinessServices.Models;
using Resolver;

namespace BusinessServices
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<ITokenServices, TokenServices>();
            registerComponent.RegisterType<IEmployeeService, EmployeeService>();
            registerComponent.RegisterType<ICompanyService,CompanyService>();
            registerComponent.RegisterType<IAuthorizeService, AuthorizeService>();
            registerComponent.RegisterType<IEpicAuditLogService, EpicAuditLogService>();
            registerComponent.RegisterType<IEpicService, EpicService>();
            registerComponent.RegisterType<IFeatureAuditLogService, FeatureAuditLogService>();
            registerComponent.RegisterType<IFeatureService, FeatureService>();
            registerComponent.RegisterType<ILeadCommunicationService, LeadCommunicationService>();
            registerComponent.RegisterType<ILeadService, LeadService>();
            registerComponent.RegisterType<IProjectDocumentService, ProjectDocumentService>();
            registerComponent.RegisterType<IProjectService, ProjectService>();
            registerComponent.RegisterType<IStatusService,StatusService>();
            registerComponent.RegisterType<ITaskAuditLogService, TaskAuditLogService>();
            registerComponent.RegisterType<ITaskService, TaskService>();
            registerComponent.RegisterType<ITeamMemberService, TeamMemberService>();
            registerComponent.RegisterType<ITeamService, TeamService>();
            registerComponent.RegisterType<IDBExecutor, DBExecutor>();
        }
    }
}