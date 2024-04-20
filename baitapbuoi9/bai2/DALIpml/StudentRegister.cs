using baitapbuoi9.bai2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai2.DALIpml
{
    public class StudentRegister : bai2.IStudentRegister
    {
        private List<(Student, Course, DateTime, double)> registrations = new List<(Student, Course, DateTime, double)>();
        public void RegisterCourse(Student student, Course course, DateTime registrationDate)
        {
            double discount = 0;
            if ((course.StartDate - registrationDate).Days >= 30)
            {
                discount = 0.15;
            }
            else if ((course.StartDate - registrationDate).Days >= 10)
            {
                discount = 0.10;
            }

            double feeAfterDiscount = course.Fee * (1 - discount);
            registrations.Add((student, course, registrationDate, feeAfterDiscount));
        }
        public void DisplayRegistrations()
        {
            var sortedRegistrations = registrations.OrderByDescending(r => r.Item4).ToList();

            foreach (var registration in sortedRegistrations)
            {
                Console.WriteLine($"Họ tên: {registration.Item1.FullName}, Ngày sinh: {registration.Item1.DateOfBirth}, Ngày đăng ký: {registration.Item3}, Học phí: {registration.Item2.Fee}, Học phí sau chiết khấu: {registration.Item4}");
            }
        }
    }
    
}
