using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Repository.Interface.Manager;
using RepositoryCrud.Models;

namespace RepositoryCrud.Interfaces.Manager
{
    interface IStudentManager:ICommonManager<Student>
    {
        bool IsExiRegNo(string regNo);
        Student GetById(int id);
    }
}
