using dotnetmysl.Data.Interfaces;
using dotnetmysl.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace dotnetmysl.Data.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly DataContext _context;        

        public EntityRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Entity> GetAll()
        {            
            return _context.Entity.ToList();
        }

        public bool Save(Entity entity)
        {
            if (entity == null)
            return false;
            _context.Entity.Add(entity);
            var created= _context.SaveChanges();
            return created>0;
        }

        public Entity Update(Entity entity)
        {     
             _context.Entity.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {          

            int deleted = 0;
            var entity = _context.Entity.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);
                deleted = _context.SaveChanges();
            }
            return deleted > 0;
        }
        public Entity GetById(int id)
        {
            return _context.Entity.FirstOrDefault(x => x.Id == id);            
             
        }
    }
}
