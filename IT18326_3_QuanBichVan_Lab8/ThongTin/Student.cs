namespace Lab8.ThongTin
{
    public class Student : Personal
    {

        //tu validate du lieu dau vao nha tui lam cach nhanh nhat

        public double Diem { get; set; }
        public string Email { get; set; }
        public string MSV { get; set; }

        public Student(string MSV, double Diem, string Email, string HoTen, string GioiTinh, string DiaChi, string NgaySinh) :
            base(HoTen, GioiTinh, DiaChi, NgaySinh)
        {
            getHoTen = HoTen;
            getNgaySinh = NgaySinh;
            getDiaChi = DiaChi;
            getGioiTinh = GioiTinh;
            this.MSV = MSV;
            this.Diem = Diem;
            this.Email = Email;
        }
        // dùng base để biêt lấy lun thông tin của personal
        public Student() : base() { }

        // tu khai bao getter setter


        public override void InputInfo()
        {
            base.InputInfo();
            MSV = Console.ReadLine();
            Diem = Convert.ToDouble(Console.ReadLine());
            Email = Console.ReadLine();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Mã số SV: {0}", MSV);
            Console.WriteLine("Điểm: {0}", Diem);
            Console.WriteLine("Email: {0}", Email);
        }
    }
}
