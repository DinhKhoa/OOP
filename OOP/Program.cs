using System.Data;
using System.Net.NetworkInformation;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book n = new Book("DAD", 4);
            Book m = new Book("DADAD");
            Book h = new Book(13);

            //n.TenSach = Console.ReadLine();
            //n.TacGia = Console.ReadLine();
            //n.NamXB = int.Parse(Console.ReadLine());
            //n.SoLuong = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nTen sach: {n.TenSach}\nTac gia: {n.TacGia}\nNam xuat ban: {n.NamXB}\nSo luong: {n.SoLuong}");
            //Console.WriteLine($"\nTen sach: {m.TenSach}\nTac gia: {m.TacGia}\nNam xuat ban: {m.NamXB}\nSo luong: {m.SoLuong}");
            //Console.WriteLine($"\nTen sach: {h.TenSach}\nTac gia: {h.TacGia}\nNam xuat ban: {h.NamXB}\nSo luong: {h.SoLuong}");

            //PrintBook(n);
            //PrintBook(m);
            //PrintBook(h);

            n.Read();

            n.WriteDetails();
            m.WriteDetails();
            h.WriteDetails();


            Object dasd = new Object();
            List<int> List = new List<int>() { };
            //Implicit Explicit
        }
        public static void PrintBook(Book book)
        {
            Console.WriteLine($"\nTen sach: {book.TenSach}\nTac gia: {book.TacGia}\nNam xuat ban: {book.NamXB}\nSo luong: {book.SoLuong}");
        }
    }
}