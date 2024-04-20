using baitapbuoi9.bai2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai2.DALIpml
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();
        private StudentRegister studentRegister = new StudentRegister();

        public void RegisterStudentForCourse()
        {
            Student student = new Student();
            bool check;
            Console.Write("Nhập họ tên học viên: ");
            string Tenhocvien;
            do
            {
                Tenhocvien = Console.ReadLine();
                if (checkInput.CheckIsNullOrWhiteSpace(Tenhocvien)||checkInput.ContainsNumber(Tenhocvien))
                    check = false;
                else check = true;
            } while (!check);
            student.FullName = Tenhocvien;
            Console.Write("Nhập ngày sinh học viên (dd/MM/yyyy): ");
            student.DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            students.Add(student);

            Course course = new Course();

            Console.Write("Nhập tên khóa học: ");
            string TenKhoaHoc;
            do
            {
                TenKhoaHoc = Console.ReadLine();
                if (checkInput.CheckIsNullOrWhiteSpace(TenKhoaHoc))
                    check = false;
                else check = true;
            } while (!check);
            course.Name = TenKhoaHoc;
            Console.Write("Nhập mô tả khóa học: ");
            course.Description = Console.ReadLine();

            Console.Write("Nhập học phí khóa học: ");
            double Hocphi;
            string Hocphinhap;
            do
            {
                Hocphinhap = Console.ReadLine();
                if (checkInput.CheckNumber(Hocphinhap, out Hocphi))
                    check = true;
                else check = false;
            } while (!check);
            course.Fee = Hocphi;

            Console.Write("Nhập ngày khai giảng (dd/MM/yyyy): ");
            DateTime ngayKhaiGiang=new DateTime();
            do
            { 
                string ngayHopLe = Console.ReadLine();
                if (checkInput.CheckDateTime(ngayHopLe))
                {
                    ngayKhaiGiang = DateTime.ParseExact(ngayHopLe, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                    check = true;
                }
                else
                    check = false;
            } while (!check);
            course.StartDate = ngayKhaiGiang;
            Console.Write("Nhập ngày đăng ký (dd/MM/yyyy): ");
            DateTime registrationDate =new DateTime();
            do
            {
                string ngayHopLe = Console.ReadLine();
                if (checkInput.CheckDateTime(ngayHopLe))
                {
                    registrationDate = DateTime.ParseExact(ngayHopLe, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None);
                    check = true;
                }
                else
                    check = false;
            } while (!check);
            studentRegister.RegisterCourse(student, course, registrationDate);

            Console.WriteLine("Đã đăng ký khóa học thành công!");
        }
        public void DisplayRegistrations()
        {
            studentRegister.DisplayRegistrations();
        }
    }
}
