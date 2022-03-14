using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Repository.Interface.Repository;
using RepositoryCrud.Models;

namespace RepositoryCrud.Interfaces.Repository
{
    interface IStudentRepository: ICommonRepository<Student>
    {
    }
}
