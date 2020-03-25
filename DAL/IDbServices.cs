using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBDTUT3.Models;

namespace APBDTUT3.DAL
{
    public interface IDbServices
    {
        public IEnumerable<Student> GetStudents();
    }
}
