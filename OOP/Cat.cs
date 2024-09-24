using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInClass
{
    public class Cat
    {
        public string Ten { get; set; }
        public string Giong { get; set; }
        public GioiTinh GioiTinh { get; set; }
        public int Tuoi { get; set; }

        public Cat()
        {
            Ten = "Chua co";
            Giong = "Chua co";
            GioiTinh = GioiTinh.Khac;
            Tuoi = 0;
        }
        public Cat(string tenMeo, string giong, GioiTinh gioiTinh, int tuoi)
        {
            Ten = tenMeo;
            Giong = giong;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
        }

        public void Read()
        {
            Console.Write("Nhap ten meo: ");
            Ten = Console.ReadLine();

            Console.Write("Nhap giong: ");
            Giong = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            Enum.TryParse(Console.ReadLine(), true, out GioiTinh gioiTinh);
            GioiTinh = gioiTinh;

            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }
        public void WriteDetails()
        {
            Console.WriteLine($"Be meo \"{Ten}\" - Giong {Giong} (gioi tinh: {GioiTinh}) - {Tuoi} tuoi.");
        }
        public int CountTheNumberOfCats(List<Cat> lstCat)
        {
            return lstCat.Count;
        }

        ~Cat()
        {
            Console.WriteLine("~~~~END~~~~");
        }
    }
    public enum GioiTinh
    {
        Duc,
        Cai,
        Khac
    }

}