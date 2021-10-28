using DataTableCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableCoreSample.Iservice
{
    public interface IstudentService
    {
        List<Student> GetStudents();
        Student GetById(int studentId);
        void Save(Student ostudent);
        void Update(Student ostudent);
        string Delete(int studentId);


    }
}
