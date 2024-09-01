namespace Bai_1
{
    class Tinh_GPA
    {
        public double qth, htttql, cslt, triet, gpa, gpa_cuoi;
        public string ten, lop, xeploai;
        public void Nhap()
        {
            Console.Write("Ho va ten: ");
            ten = Console.ReadLine();
            Console.Write("Lop: ");
            lop = Console.ReadLine();
            Console.Write("Diem_QTH: ");
            qth = double.Parse(Console.ReadLine());
            Console.Write("Diem_HTTTQL: ");
            htttql = double.Parse(Console.ReadLine());
            Console.Write("Diem_CSLT: ");
            cslt = double.Parse(Console.ReadLine());
            Console.Write("Diem_Triet: ");
            triet = double.Parse(Console.ReadLine());
        }
        public void KetQua()
        {
            double[] Diem = {qth, cslt, htttql, triet};
            foreach (double item in Diem)
            {
                if (item >= 8.5) gpa += 4;
                else if (item >= 7 & item < 8.5) gpa += 3;
                else if (item >= 5.5 & item < 7) gpa += 2;
                else if (item >= 4 & item < 5.5) gpa += 1;
                else gpa += 0;
            }
            gpa_cuoi = gpa/4;
            if (gpa_cuoi >= 3.6) xeploai = "Xuat Sac";
            else if (gpa_cuoi >= 3.2 & gpa_cuoi < 3.6) xeploai = "Gioi";
            else if (gpa_cuoi >= 2.5 & gpa_cuoi < 3.2) xeploai = "Kha";
            else if (gpa_cuoi >= 2 & gpa_cuoi < 2.5) xeploai = "Trung Binh";
            else xeploai = "Yeu";
            Console.WriteLine("Sinh vien {0}, Lop {1}, Dat GPA {2}, Xep loai {3}", ten,lop,gpa_cuoi,xeploai);
        }
    }
    class Program_1
    {
        public static void Main(string[] args)
        {
            Tinh_GPA sv1 = new Tinh_GPA();
            sv1.Nhap();
            sv1.KetQua();
            Tinh_GPA sv2 = new Tinh_GPA();
            sv2.Nhap();
            sv2.KetQua();           
        }
    }
}