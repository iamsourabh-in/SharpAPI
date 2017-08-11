using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class StatusService : IStatusService
    {

        public BusinessEntities.StatusEntity GetTaskById(long statusId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessEntities.StatusEntity> GetAllStatuses(long companyId)
        {
            throw new NotImplementedException();
        }

        public long CreateTask(BusinessEntities.StatusEntity statusEntity)
        {
            throw new NotImplementedException();
        }
    }
}
