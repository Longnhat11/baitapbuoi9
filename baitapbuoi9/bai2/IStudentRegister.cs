using baitapbuoi9.bai2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai2
{
    public interface IStudentRegister
    {
        void RegisterCourse(Student student, Course course, DateTime registrationDate);
    }
}
