using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF.Repository.Repository;
using RepositoryCrud.Data;
using RepositoryCrud.Interfaces.Repository;
using RepositoryCrud.Models;

namespace RepositoryCrud.Repository
{
    public class StudentRepository:CommonRepository<Student>,IStudentRepository
    {
        public StudentRepository():base(new ApplicationDbContext())
        {

        }
    }
}