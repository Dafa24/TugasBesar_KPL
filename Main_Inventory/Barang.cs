using System;

public class Class1
{
	public Class1()
	{

        public string NamaBarang { get; set; }

        public int KodeBarang { get; set; }

        public int JumlahBarang { get; set; }

        public int HargaBarang { get; set; }

        public Barang(string NamaBarang, int KodeBarang, int JumlahBarang, int HargaBarang)
        {
            this.NamaBarang = NamaBarang;
            this.KodeBarang = KodeBarang;
            this.JumlahBarang = JumlahBarang;
            this.HargaBarang = HargaBarang;
        }   
}
}
