using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BookClass
    {
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public int NamXB { get; set; }
        public int SoLuong { get; set; }

        public BookClass()
        {
            SoLuong = 1;
        }
        public BookClass(int soLuong)
        {
            SoLuong = soLuong;
        }
        public BookClass(string tenSach)
        {
            TenSach = tenSach;
        }
        public BookClass(string tenSach, int soLuong)
        {
            TenSach = tenSach;
            SoLuong = soLuong;
        }

        public void Read()
        {
            TenSach = Console.ReadLine();
            TacGia = Console.ReadLine();
            NamXB = int.Parse(Console.ReadLine());
            SoLuong = int.Parse(Console.ReadLine());
        }
        public void WriteDetails()
        {
            Console.WriteLine($"\nTen sach: {TenSach}\nTac gia: {TacGia}\nNam xuat ban: {NamXB}\nSo luong: {SoLuong}");
        }

        ~BookClass()
        {
            Console.WriteLine("Du lieu da duoc xoa.");
        }
    }
}
