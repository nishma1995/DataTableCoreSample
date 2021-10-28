using DataTableCoreSample.Context;
using DataTableCoreSample.Iservice;
using DataTableCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableCoreSample.Service
{
    public class StudentService : IstudentService
    {
        private readonly DatabaseContext _context;
        public StudentService(DatabaseContext context)
        {
            _context= context;
        }
        public string Delete(int studentId)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == studentId);
            if(student!=null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                
            }
            return "Deleted";
        }

        public Student GetById(int studentId)
        {
            return _context.Students.SingleOrDefault(x=>x.Id==studentId);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public void Save(Student ostudent)
        {
            _context.Students.Add(ostudent);
            _context.SaveChanges();
        }

        public void Update(Student ostudent)
        {
            _context.Students.Update(ostudent);
            _context.SaveChanges();
        }
    }
}
