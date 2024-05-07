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
        public enum JenisBarang
        {
            Elektronik,
            Pakaian,
            Makananan,
        }

        public class Barang
        {
            public int Id { get; set; }
            public string Nama { get; set; }
            public string Deskripsi { get; set; }
            public int Harga { get; set; }
            public JenisBarang Jenis { get; set; }
        }


        public class TabelInventaris
        {
            private data<int, Barang> tabelBarang;
            private int nextId;

            public TabelInventaris()
            {
                tabelBarang = new data<int, Barang>();
                nextId = 1;
            }
        }
    }
}