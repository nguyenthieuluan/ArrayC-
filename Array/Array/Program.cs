using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");
            //array khởi tạo cần có số lượng phần tử.
            int[] array = new int[5];
            int[] array1 = new int[2] { 1, 2 };
            int[] array2 = { 1, 2, 3 };
            int[] array3 = new int[] { 0, 1, 2 };
            array = array2;
            foreach (int x in array)
            {
                Console.WriteLine(x.ToString());
            }
            ///
            Console.WriteLine("ArrayList - Collection");
            //ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add("nguyen");
            arrayList.Add("thieu");
            arrayList.Add("luan");
            ArrayList arrayList1 = new ArrayList() { 1, 2, 3, 4 };
            ArrayList arrayList2 = new ArrayList(3) { 1, 2 };
            arrayList2.Add("them");
            arrayList2.Add("chuoi"); //có thể thêm kiểu dữ liệu khác.
            foreach (var x in arrayList2)
            {
                Console.WriteLine(x);
            }
            // => lưu mãng object
            // => khi đọc giá trị thì phải ép kiểu giá trị
            // số lượng phần tử lớn > chậm.

            Console.WriteLine("\nList - Generic");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            List<string> list1 = new List<string> { "a", "b", "c" };
            foreach(var x in list1)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("\nObservable");
            ObservableCollection<int> observableCollection = new ObservableCollection<int>() { 4,3,2,1 };
            foreach(var x in observableCollection)
            {
                Console.Write(x+" ");
            }
            Console.ReadKey();


        }
    }
}
