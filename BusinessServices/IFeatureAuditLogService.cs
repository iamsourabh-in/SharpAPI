using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IFeatureAuditLogService
    {
        FeatureAuditLogEntity GetFeatureAuditLogEntityById(long featureAuditLogEntityId);
        IEnumerable<FeatureAuditLogEntity> GetAllFeatureAuditLog(long featureId);
        long CreateCompany(FeatureAuditLogEntity featureAuditLogEntity);
        bool UpdateCompany(long featureAuditLogId, FeatureAuditLogEntity featureAuditLogEntity);
        bool DeleteCompany(long featureAuditLogId);
    }
}
