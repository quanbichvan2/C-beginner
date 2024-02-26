using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class HocVien
    {
        private string MaSV { get; set; }
        /*Phân tích tên sinh viên thành họ và tên (nếu cần upgrage)
        private string? firstName;
        private string? lastName;
        */
        private string HoTen { get; set; }
        private string Email { get; set; }
        private double Diem { get; set; }


        //Hàm tạo cho trường hợp nhập bằng excel hay đại loại bla bla (nếu cần upgrage)
        public HocVien(string MaSV, string HoTen, string Email, double Diem)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.Diem = Diem;
            this.Email = Email;
        }

        public string getMaSV
        {
            get
            {
                return this.MaSV;
            }
            set
            {
                this.MaSV = value;
            }
        }
        public string getHoten
        {
            get
            {
                return this.HoTen;
            }
            set
            {
                this.HoTen = value;
            }
        }
        public string getEmail
        {
            get
            {
                return this.Email;
            }
            set
            {
                this.Email = value;
            }
        }
        public double getDiem
        {
            get
            {
                return this.Diem;
            }
            set
            {
                this.Diem = value;
            }
        }
    }
}
