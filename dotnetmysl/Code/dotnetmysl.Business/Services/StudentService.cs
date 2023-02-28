using dotnetmysl.Business.Interfaces;
using dotnetmysl.Data.Interfaces;
using dotnetmysl.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetmysl.Business.Services
{
    public class StudentService : IStudentService
    {
        IStudentRepository _StudentRepository;

        public StudentService(IStudentRepository StudentRepository)
        {
           this._StudentRepository = StudentRepository;
        }
        public IEnumerable<Student> GetAll()
        {
            return _StudentRepository.GetAll();
        }

        public Student Save(Student Student)
        {
            _StudentRepository.Save(Student);
            return Student;
        }

        public Student Update(Student Student)
        {
            return _StudentRepository.Update( Student);
        }

        public bool Delete(int id)
        {
            return _StudentRepository.Delete(id);
        }
        public Student GetById(int id)
        {
            return _StudentRepository.GetById(id);
        }
    }
}
