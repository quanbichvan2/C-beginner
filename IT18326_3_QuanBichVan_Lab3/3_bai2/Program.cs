using System.Text;
class program
{
    static void Main(string[] args){
        Console.OutputEncoding = Encoding.UTF8;
        List<String?> hoTen = new List<String?>();
        List<Double> diem = new List<Double>();
        Console.WriteLine("Nhập số sinh viên cần nhập");
        Console.Write("Nhập: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Console.Write($"Nhập tên sinh viên {i + 1}: ");
            hoTen.Add(Console.ReadLine());
            Console.Write($"Nhập điểm: ");
            diem.Add(Convert.ToInt32(Console.ReadLine()));
            while (diem[i] < 0 || diem[i] > 10)
            {
                Console.Write("Điểm sai mời nhập lại\nNhập lại: ");
                diem[i] = (Convert.ToInt32(Console.ReadLine()));
            }
        }

        tempSort(hoTen, diem, number);

        xuat(hoTen, diem, number);


        void xuat(List<String?> hoTen, List<Double> diem, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("___________________________");
                Console.Write($"{hoTen[i]}\t{diem[i]}\t|");
                if (diem[i] < 5)
                {
                    Console.Write("Yếu");
                }
                else if (diem[i] < 6.5)
                {
                    Console.Write("Trung Bình");
                }
                else if (diem[i] < 7.5)
                {
                    Console.Write("Khá");
                }
                else if (diem[i] < 9)
                {
                    Console.Write("Giỏi");
                }
                else
                {
                    Console.Write("Xuất sắc");
                }
                Console.WriteLine();
            }
        }

        void tempSort(List<string?> hoTen, List<double> diem, int nuint)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (diem[i] < diem[j])
                    {
                        Double temp1 = diem[i];
                        string? temp2 = hoTen[i];
                        diem[i] = diem[j];
                        hoTen[i] = hoTen[j];
                        diem[j] = temp1;
                        hoTen[j] = temp2;
                    }
                }
            }
        }

        /*quick test
        5
        Hoang
        10
        Duong
        7
        Dat
        8
        Son
        2
        Viet
        5
        */
    }
}