using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface ITaskService
    {
        TaskEntity GetTaskById(long taskId);
        IEnumerable<TaskEntity> GetAllTasks(long featureId);
        long CreateTask(TaskEntity taskEntity);
        bool UpdateTask(long taskId, TaskEntity taskEntity);
        bool DeleteTask(long taskId);
    }
}
