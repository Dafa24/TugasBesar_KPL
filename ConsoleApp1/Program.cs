using TableDriven;

internal class Program
{
        public static void Main(string[] args)
    {
        TableDriven alatElektronik = TableDriven.Komputer;
        string namaAlat = GetNamaElektronik(alatElektronik);
        Console.WriteLine("Bulan " + alatElektronik + " memiliki jumlah harinya adalah: " + namaAlat + " hari.");
    }
}