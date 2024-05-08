using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main_Inventory;


namespace Main_Inventory
{
	internal class Gudang
	{
        private List<Barang> DataBarang = new List<Barang>
             {
                new Barang("Ipad", 1, 10 ,25000),
                new Barang("Laptop",2 , 15 ,28000),
                new Barang("Keyboard",3, 20 ,35000),

            };

        public void cariBarang(string NamaBarang)
        {

            for (int i = 0; i < DataBarang.Count; i++)
            {
                if (NamaBarang == DataBarang[i].NamaBarang)
                {
                    Console.WriteLine("Nama Barang: " + DataBarang[i].NamaBarang);
                    Console.WriteLine("Kode Barang" + DataBarang[i].KodeBarang);
                    Console.WriteLine("Jumlah Barang: " + DataBarang[i].JumlahBarang);
                    Console.WriteLine("Harga Barang: " + DataBarang[i].HargaBarang);
                  
                }
            }
        }
    public int returnIndex(string NamaBarang)
    {
        int index = -1;

        for (int i = 0; i < DataBarang.Count; i++)
        {
            if (NamaBarang == DataBarang[i].NamaBarang)
            {
                return index = i;
                break;
            }
        }

        return index;
    }
}
}
