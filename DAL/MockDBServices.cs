using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBDTUT3.Models;

namespace APBDTUT3.DAL
{
    public class MockDBServices : IDbServices
    {
        private static IEnumerable<Student> _students;

        static MockDBServices() {
            _students = new List<Student>
            {
                new Student { IdStudent = 1, Firstname = "Simphiwe", LastName = "Dlamini" },
            new Student { IdStudent = 2, Firstname = "Vuyo", LastName = "Ndabandaba" },
            new Student { IdStudent = 3, Firstname = "Ntokozo " ,LastName = "Ndabandaba"}
            };
        }

        public IEnumerable<Student> GetStudents() { return _students};
    }
}
