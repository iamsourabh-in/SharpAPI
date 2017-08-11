using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface ILeadCommunicationService
    {
        LeadCommunicationEntity GetLeadCommunicationById(long leadCommunicationId);
        IEnumerable<LeadCommunicationEntity> GetAllLeadCommunication();
        long CreateCompany(LeadCommunicationEntity leadCommunicationEntity);
        bool UpdateCompany(long leadCommunicationId, LeadCommunicationEntity leadCommunicationEntity);
        bool DeleteCompany(long leadCommunicationId);
    }
}
