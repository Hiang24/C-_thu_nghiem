namespace Cau1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ho va ten: ");
            string ten = Console.ReadLine();
            Console.Write("Lop: ");
            string lop = Console.ReadLine();
            Console.WriteLine("Diem QTH: ");
            float qth = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem HTTTQL:" );
            float ht = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem CSTL: ");
            float cslt = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem Triet:" );
            float triet = float.Parse(Console.ReadLine());
            float gpa = 0;
            float gpa_tong = 0;
            string xep_loai = "";
            float[] Diem = {qth,ht,cslt,triet}; //Tạo mảng Diem để chứa điểm 4 môn
            foreach (float i in Diem) //foreach cũng như hàm for nhma nó sẽ kiểu chạy trong 1 mảng hoặc list
            {
                if (i >= 8.5)
                {
                    gpa += 4;
                }
                else if (i >= 7 && i < 8.5)
                {
                    gpa += 3;
                }
                else if (i >= 5.5 && i < 7) {gpa += 2;}
                else if (i >= 4 && i < 5.5) gpa += 1;
                else gpa += 0;
                //Ghi if/else if bằng cách nào cũng được, tùy xem có nhiều điều kiện hay không  
            }
            gpa_tong = gpa / 4;
            if (gpa_tong >= 3.6) xep_loai = "Xuat sac";
            else if (gpa_tong >= 3.2 && gpa_tong < 3.6) xep_loai = "Gioi";
            else if (gpa_tong >= 2.5 && gpa_tong < 3.2) xep_loai = "Kha";
            else if (gpa_tong >= 2 && gpa_tong < 2.5) xep_loai = "Trung binh";
            else xep_loai = "Yeu";
            Console.WriteLine("");
        }
    }
}