using System;
using System.Collections.Generic;

namespace Class1
{
    // Kelas Barang untuk merepresentasikan sebuah barang
    public class Barang
    {
        public string Nama { get; set; }
        public int Jumlah { get; set; }
        public int id { get; set; }
        public int harga { get; set; }
        public string jenis { get; set; }


        public Barang(string nama, int id, int jumlah, int harga, string jenis)
        {
            this.Nama = nama;
            this.Jumlah = jumlah;
            this.id = id;
            this.harga = harga;
            this.jenis = jenis;
        }
    }

    public class Inventaris // kenapa ga bisa pake static? di lms biasanya method atau class library menggunakan static
    {
        public Dictionary<string, Barang> daftarBarang;

        public Inventaris()
        {
            daftarBarang = new Dictionary<string, Barang>();
        }

        public void TambahStokBarang(string nama, int id, int jumlah, int harga, string jenis)
        {
            //Console.WriteLine("Masukan nama barang : ");
            // nama = Console.ReadLine();
            if (daftarBarang.ContainsKey(nama))
            {
                daftarBarang[nama].Jumlah += jumlah;
            }
            else
            {
                Barang barangBaru = new Barang(nama, id, jumlah, harga, jenis);
                daftarBarang.Add(nama, barangBaru);
            }
        }

        public void HapusBarang(string nama, int id, int jumlah, int harga, string jenis)
        {
            if (daftarBarang.ContainsKey(nama))
            {
                daftarBarang[nama].Jumlah -= jumlah;
                if (daftarBarang[nama].Jumlah <= 0)
                {
                    daftarBarang.Remove(nama);
                }
            }
            else
            {
                Console.WriteLine("Barang tidak ditemukan dalam inventaris.");
            }
        }

        public void TampilkanInventaris()
        {
            Console.WriteLine("Inventaris Barang:");
            foreach (var barang in daftarBarang.Values)
            {
                Console.WriteLine("Nomor Barang  :" + barang.id);
                Console.WriteLine("Nama Barang   :" + barang.Nama);
                Console.WriteLine("Jumlah Barang :" + barang.Jumlah);
                Console.WriteLine("Harga         :" + barang.harga);
                Console.WriteLine("");
            }
        }
    }
}