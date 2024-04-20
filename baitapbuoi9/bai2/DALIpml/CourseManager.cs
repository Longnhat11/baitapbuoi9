using baitapbuoi9.bai2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapbuoi9.bai2.DALIpml
{
    public class CourseManager
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse()
        {
            Course course = new Course();

            Console.Write("Nhập tên khóa học: ");
            bool check;
            string tenKhoa;
            do
            {
                tenKhoa = Console.ReadLine();
                if (checkInput.CheckIsNullOrWhiteSpace(tenKhoa))
                    check = false;
                else check = true;
            } while (!check);
            course.Name = tenKhoa;
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
            course.Fee=Hocphi;
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
            courses.Add(course);

            Console.WriteLine("Đã thêm khóa học thành công!");
        }
    }
}
