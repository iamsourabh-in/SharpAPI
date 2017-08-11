using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    interface ILeadService
    {
        LeadEntity GetLeadById(long leadId);
        IEnumerable<LeadEntity> GetAllLeads();
        long CreateLead(LeadEntity leadEntity);
        bool UpdateLead(long leadId, LeadEntity leadEntity);
        bool DeleteLead(long leadId);
    }
}
