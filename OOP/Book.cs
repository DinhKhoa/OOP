using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInClass
{
    public class Book
    {
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public int NamXB { get; set; }
        public int SoLuong { get; set; }

        public Book()
        {
            TenSach = "Chua co";
            TacGia = "Chua co";
            NamXB = 0;
            SoLuong = 0;
        }
        public Book(string tenSach, string tacGia, int namXB, int soLuong)
        {
            TenSach = tenSach;
            TacGia = tacGia;
            NamXB = namXB;
            SoLuong = soLuong;
        }

        public void Read()
        {
            Console.Write("Nhap ten sach: ");
            TenSach = Console.ReadLine();

            Console.Write("Nhap ten tac gia: ");
            TacGia = Console.ReadLine();

            Console.Write("Nhap nam xuat ban: ");
            NamXB = int.Parse(Console.ReadLine());

            Console.Write("Nhap so luong sach: ");
            SoLuong = int.Parse(Console.ReadLine());
        }
        public void WriteDetails()
        {
            Console.WriteLine($"\nCuon \"{TenSach}\" - tac gia {TacGia} (xuat ban nam {NamXB}), So luong sach: {SoLuong} cuon.");
        }

        ~Book()
        {
            Console.WriteLine("~~~~END~~~~");
        }
    }
}
