using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessServices
{

    public interface IProjectService
    {
        ProjectEntity GetProjectById(long projectId);
        IEnumerable<ProjectEntity> GetAllProjects();
        long CreateProject(ProjectEntity projectEntity);
        bool UpdateProject(long projectId, ProjectEntity projectEntity);
        bool DeleteProject(long projectId);
    }
}
