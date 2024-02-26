using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class MyCompare : IComparer<Book>
{
    public int Compare(Book? x, Book? y)
    {
        int result = x.tenTacGia.CompareTo(y.tenTacGia);
        //test
        //Console.WriteLine($"x tac gia: {x.tenTacGia}");
        //Console.WriteLine($"y tac gia:{y.tenTacGia} ");
        //Console.WriteLine(result);
        // nếu tên tác giả giống nhau thì result == 0 . Vậy tiếp tục so sánh tên sách
        if (result == 0)
            result = x.tenSach.CompareTo(y.tenSach);
        // nếu tên sách giống nhau thì result == 0 . Vậy tiếp tục so sánh năm xuất bản
        if (result == 0)
            result = x.namXuatBan.CompareTo(y.namXuatBan);

        return result; 

    }

}
