using dotnetmysl.Business.Interfaces;
using dotnetmysl.Data.Interfaces;
using dotnetmysl.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetmysl.Business.Services
{
    public class EntityService : IEntityService
    {
        IEntityRepository _EntityRepository;

        public EntityService(IEntityRepository EntityRepository)
        {
           this._EntityRepository = EntityRepository;
        }
        public IEnumerable<Entity> GetAll()
        {
            return _EntityRepository.GetAll();
        }

        public Entity Save(Entity Entity)
        {
            _EntityRepository.Save(Entity);
            return Entity;
        }

        public Entity Update(Entity Entity)
        {
            return _EntityRepository.Update( Entity);
        }

        public bool Delete(int id)
        {
            return _EntityRepository.Delete(id);
        }
        public Entity GetById(int id)
        {
            return _EntityRepository.GetById(id);
        }
    }
}
