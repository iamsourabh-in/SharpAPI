using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IEpicAuditLogService 
    {
        EpicAuditLogEntity GetEpicAuditLogById(long companyId);
        IEnumerable<EpicAuditLogEntity> GetAllEpicAuditLog();
        long CreateCompany(EpicAuditLogEntity epicAuditLogEntity);
        bool UpdateCompany(long epicAuditLogId, EpicAuditLogEntity epicAuditLogEntity);
        bool DeleteCompany(long epicAuditLogId);
    }
}
