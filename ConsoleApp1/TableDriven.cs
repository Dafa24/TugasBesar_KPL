using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.TableDriven;


namespace ConsoleApp1
{
    internal class TableDriven
    {
        public enum Elektronik
        {
            Smartphone,
            Tv,
            Kulkas,
            Laptop,
            Keyboard,
            Monitor,
            Mouse,
            Komputer
        }


        public static int GetNamaElektronik(TableDriven inputnama)
        {
            string[] outputNama = { "Xiaomi 13T", "LG 24Mk", "Samsung Cooler", "ASUS ROG", "Razer", "Viewsonic", "Logitech", "HonzonGamingPC" };
            return outputNama[(string)inputnama];
        }


       public class Barang
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public int Harga { get; set; }
            public JenisBarang Jenis { get; set; }
        }

        public Barang(int id,string Nama, int Harga, JenisBarang Jenis) {
            this.id = id;
            this.Nama = Nama;
            this.Harga = Harga;
            this.JenisBarang = Jenis;
        }

          public void displayBarang()
        {
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Nama : " + Nama);
            Console.WriteLine("Harga : " + Harga);
            Console.WriteLine("Jenis Barang : " + JenisBarang);
        }

    }
}