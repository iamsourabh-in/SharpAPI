using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class FeatureAuditLogService : IFeatureAuditLogService
    {
        public BusinessEntities.FeatureAuditLogEntity GetFeatureAuditLogEntityById(long featureAuditLogEntityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessEntities.FeatureAuditLogEntity> GetAllFeatureAuditLog(long featureId)
        {
            throw new NotImplementedException();
        }

        public long CreateCompany(BusinessEntities.FeatureAuditLogEntity featureAuditLogEntity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCompany(long featureAuditLogId, BusinessEntities.FeatureAuditLogEntity featureAuditLogEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCompany(long featureAuditLogId)
        {
            throw new NotImplementedException();
        }
    }
}
