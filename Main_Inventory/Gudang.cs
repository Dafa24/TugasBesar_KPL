using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryInven;


namespace Main_Inventori
{
	internal class Gudang
	{
          private List<Barang> Barang = new List<Barang>
             {
                new Barang("Ipad", "K001", 10 ,25000),
                new Barang("Laptop", "K002", 15 ,28000),
                new Barang("Keyboard", "K003", 20 ,35000),

            };
    public void cariBarang(string NamaBarang)
        {

            for (int i = 0; i < barangArray.Length; i++)
            {
                if (judul == barangArray[i].NamaBarang)
                {
                    Console.WriteLine("Nama Barang: " + barangArray[i].NamaBarang);
                    Console.WriteLine("Kode Barang" + barangArray[i].KodeBarang);
                    Console.WriteLine("Jumlah Barang: " + barangArray[i].JumlahBarang);
                    Console.WriteLine("Harga Barang: " + barangArray[i].HargaBarang);
                  
                }
            }
        }
    public int returnIndex(string NamaBarang)
    {
        int index = -1;

        for (int i = 0; i < barangArray.Length; i++)
        {
            if (NamaBarang == barangArray[i].NamaBarang)
            {
                return index = i;
                break;
            }
        }

        return index;
    }
}
}
