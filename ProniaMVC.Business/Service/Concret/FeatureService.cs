using ProniaMVC.Business.Service.Abstract;
using ProniaMVC.Core.Models;
using ProniaMVC.Core.RepsitoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaMVC.Business.Service.Concret
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;

        public FeatureService(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }
        public async Task AddFeature(Feature feature)
        {
           await _featureRepository.AddAsync(feature);
           await _featureRepository.CommitAsync();  
        }

        public void DeleteFeature(int id)
        {
            var exsist= _featureRepository.Get(x=> x.Id == id); 
            if (exsist == null)  throw new NullReferenceException();

            _featureRepository.Delete(exsist);
        }

        public List<Feature> GetAllFeatures(Func<Feature, bool>? func = null)
        {
              return  _featureRepository.GetAll(func);
        }

        public Feature GetFeature(Func<Feature, bool>? func = null)
        {
            return _featureRepository.Get(func);
        }

        public void UpdateFeature(int id, Feature newFeature)
        {
            Feature oldFeature= _featureRepository.Get(x=>x.Id == id);
            if(oldFeature == null) throw new NullReferenceException();

            oldFeature.Icon = newFeature.Icon;
            oldFeature.Name = newFeature.Name;
            oldFeature.Description = newFeature.Description;    
        }
    }
}
