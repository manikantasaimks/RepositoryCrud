using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF.Repository.Manager;
using RepositoryCrud.Interfaces.Manager;
using RepositoryCrud.Models;
using RepositoryCrud.Repository;

namespace RepositoryCrud.Manager
{
    public class StudentManager:CommonManager<Student>,IStudentManager
    {
        public StudentManager():base(new StudentRepository())
        {

        }

        public Student GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }

        public bool IsExiRegNo(string regNo)
        {
            var student = GetFirstOrDefault(c => c.RegNo.ToLower() == regNo.ToLower());
            if(student!=null)
            {
                return true;
            }
            return false;
        }
    }
}