using dotnetmysl.Data.Interfaces;
using dotnetmysl.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace dotnetmysl.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;        

        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetAll()
        {            
            return _context.Student.ToList();
        }

        public bool Save(Student entity)
        {
            if (entity == null)
            return false;
            _context.Student.Add(entity);
            var created= _context.SaveChanges();
            return created>0;
        }

        public Student Update(Student entity)
        {     
             _context.Student.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {          

            int deleted = 0;
            var entity = _context.Student.FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                _context.Remove(entity);
                deleted = _context.SaveChanges();
            }
            return deleted > 0;
        }
        public Student GetById(int id)
        {
            return _context.Student.FirstOrDefault(x => x.Id == id);            
             
        }
    }
}
