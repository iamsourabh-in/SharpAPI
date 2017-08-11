using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    class EpicService : IEpicService
    {

        public BusinessEntities.EpicEntity GetEpicById(long epicId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessEntities.EpicEntity> GetAllEpics(long projectId)
        {
            throw new NotImplementedException();
        }

        public long CreateEpic(BusinessEntities.EpicEntity epicEntity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEpic(long epicId, BusinessEntities.EpicEntity epicEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEpic(long epicId)
        {
            throw new NotImplementedException();
        }
    }
}
