using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class FeatureService : IFeatureService
    {
        public BusinessEntities.FeatureEntity GetFeatureById(long featureId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BusinessEntities.FeatureEntity> GetAllFeature(long epicId)
        {
            throw new NotImplementedException();
        }

        public long CreateEpic(BusinessEntities.FeatureEntity featureEntity)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEpic(long featureId, BusinessEntities.FeatureEntity featureEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEpic(long featureId)
        {
            throw new NotImplementedException();
        }
    }
}
