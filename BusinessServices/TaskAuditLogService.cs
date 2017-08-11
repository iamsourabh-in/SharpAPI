using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class TaskAuditLogService : ITaskAuditLogService
    {
        public BusinessEntities.TaskAuditLogEntity GetTaskById(long taskAuditLogId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessEntities.TaskAuditLogEntity> GetAllTaskAuditLogs(long taskId)
        {
            throw new NotImplementedException();
        }

        public long CreateTaskAuditLog(BusinessEntities.TaskAuditLogEntity taskAuditLogEntity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTaskAuditLog(long taskAuditLogId, BusinessEntities.TaskAuditLogEntity taskEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTaskAuditLog(long taskAuditLogId)
        {
            throw new NotImplementedException();
        }
    }
}
