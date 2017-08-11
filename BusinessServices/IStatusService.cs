using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IStatusService
    {
        StatusEntity GetTaskById(long statusId);
        IEnumerable<StatusEntity> GetAllStatuses(long companyId);
        long CreateTask(StatusEntity statusEntity);
    }
}
