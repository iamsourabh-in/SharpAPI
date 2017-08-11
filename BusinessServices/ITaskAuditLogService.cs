using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface ITaskAuditLogService
    {
        TaskAuditLogEntity GetTaskById(long taskAuditLogId);
        IEnumerable<TaskAuditLogEntity> GetAllTaskAuditLogs(long taskId);
        long CreateTaskAuditLog(TaskAuditLogEntity taskAuditLogEntity);
        bool UpdateTaskAuditLog(long taskAuditLogId, TaskAuditLogEntity taskEntity);
        bool DeleteTaskAuditLog(long taskAuditLogId);
    }
}
