using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class TaskService : ITaskService
    {
        public BusinessEntities.TaskEntity GetTaskById(long taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessEntities.TaskEntity> GetAllTasks(long featureId)
        {
            throw new NotImplementedException();
        }

        public long CreateTask(BusinessEntities.TaskEntity taskEntity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTask(long taskId, BusinessEntities.TaskEntity taskEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTask(long taskId)
        {
            throw new NotImplementedException();
        }
    }
}
