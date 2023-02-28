using dotnetmysl.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetmysl.Business.Interfaces
{
    public interface IStudentService
    {      
        IEnumerable<Student> GetAll();
        Student Save(Student classification);
        Student Update(Student classification);
        bool Delete(int id);
        Student  GetById(int id);

    }
}
