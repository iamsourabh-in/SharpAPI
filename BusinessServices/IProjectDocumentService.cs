using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IProjectDocumentService
    {
        ProjectDocumentEntity GetProjectDocumentById(long projectDocumentId);
        IEnumerable<ProjectDocumentEntity> GetAllProjectDocuments(long projectId);
        long AddProjectDocument(ProjectDocumentEntity projectDocumentEntity);
        bool UpdateProjectDocument(long projectDocumentId, ProjectDocumentEntity projectDocumentEntity);
        bool DeleteProjectDocument(long projectDocumentId);
    }
}
