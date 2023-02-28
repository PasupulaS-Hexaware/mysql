using dotnetmysl.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetmysl.Business.Interfaces
{
    public interface IEntityService
    {      
        IEnumerable<Entity> GetAll();
        Entity Save(Entity classification);
        Entity Update(Entity classification);
        bool Delete(int id);
        Entity  GetById(int id);

    }
}
