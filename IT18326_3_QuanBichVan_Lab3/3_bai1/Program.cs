using System.Collections;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        //Array
        int count = 0, sum = 0;
        Console.WriteLine("Nhập Array");
        int[] myArray = new int[3];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Nhập phần tử {0} = ", i + 1);
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(myArray);
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("Phần tử {0} = {1}\t", i + 1, myArray[i]);
        }
        Console.WriteLine("\nMin = {0}", myArray.Min());
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 3 == 0)
            {
                count += 1;
                sum += myArray[i];
            }
        }
        if (count == 0)
        {
            count = 1;
        }
        Console.WriteLine("TBC Các số chia hết cho 3 trong Array = {0}", sum / count);
        Console.WriteLine("\n__________________________________");
        Console.WriteLine("\nCách 2: Nhập ArrayList");

        //ArrayList
        count = 0; sum = 0;
        ArrayList myArrayList = new ArrayList();
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Nhập phần tử {0} =  ", (i + 1));
            myArrayList.Add(Convert.ToInt32(Console.ReadLine()));
        }

        myArrayList.Sort();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Phần tử {0} = {1}\t", i + 1, myArrayList[i]);
        }
        Console.WriteLine("\nMin = {0}", myArrayList[0]);

        for (int i = 0; i < myArrayList.Count; i++)
        {
            if (Convert.ToInt32(myArrayList[i]) % 3 == 0)
            {
                count += 1;
                sum += Convert.ToInt32(myArrayList[i]);
            }
        }
        if (count == 0)
        {
            count = 1;
        }
        Console.WriteLine("TBC Các số chia hết cho 3 trong ArrayList = {0}", sum / count);
        Console.WriteLine("\n__________________________________");

    }
}
