using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class LeadCommunicationService :ILeadCommunicationService
    {

        public BusinessEntities.LeadCommunicationEntity GetLeadCommunicationById(long leadCommunicationId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessEntities.LeadCommunicationEntity> GetAllLeadCommunication()
        {
            throw new NotImplementedException();
        }

        public long CreateCompany(BusinessEntities.LeadCommunicationEntity leadCommunicationEntity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCompany(long leadCommunicationId, BusinessEntities.LeadCommunicationEntity leadCommunicationEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCompany(long leadCommunicationId)
        {
            throw new NotImplementedException();
        }
    }
}
