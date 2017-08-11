using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface IFeatureService
    {
        FeatureEntity GetFeatureById(long featureId);
        IEnumerable<FeatureEntity> GetAllFeature(long epicId);
        long CreateEpic(FeatureEntity featureEntity);
        bool UpdateEpic(long featureId, FeatureEntity featureEntity);
        bool DeleteEpic(long featureId);

    }
}
