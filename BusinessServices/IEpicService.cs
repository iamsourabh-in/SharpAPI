using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IEpicService
    {
        EpicEntity GetEpicById(long epicId);
        IEnumerable<EpicEntity> GetAllEpics(long projectId);
        long CreateEpic(EpicEntity epicEntity);
        bool UpdateEpic(long epicId, EpicEntity epicEntity);
        bool DeleteEpic(long epicId);
    }
}
