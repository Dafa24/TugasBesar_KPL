using System;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        AppKonfig cfg = new AppKonfig();

        Console.Write("Choose Language: (en/id) ");
        string Bahasa = Console.ReadLine();

        if (Bahasa == "id")
        {
            Console.WriteLine(cfg.konfig.pesanAwal.id);
        }
        else
        {
            Console.WriteLine(cfg.konfig.pesanAwal.en);
        }

        Console.Write("Nama Barang:");
        string jenisBarang = Console.ReadLine();

        Console.Write("Harga Barang:");
        double hargaBarang = Convert.ToDouble(Console.ReadLine());

        double totalDiskon = 0;

        if (cfg.konfig.jenisKenaDiskon.Contains(jenisBarang))
        {
            totalDiskon = hargaBarang * cfg.konfig.diskon / 100;
        }
        Console.WriteLine(hargaBarang - totalDiskon);
    }

    public class AppKonfig
    {

        public Konfig konfig;

        private const string filePath = "D://JSON/konfigkpl.json";
        //private const string filePath = @"konfigkpl.json";

        public AppKonfig()
        {
            try
            {
                ReadKonfigFile();
            }
            catch
            {
                SetDefault();
                WriteKonfigFile();
            }
        }

        public void ReadKonfigFile()
        {
            String configJsonData = File.ReadAllText(filePath);
            konfig = JsonSerializer.Deserialize<Konfig>(configJsonData);
        }

        public void WriteKonfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            String tulisan = JsonSerializer.Serialize(konfig);
            File.WriteAllText(filePath, tulisan);
        }

        public void SetDefault()
        {
            konfig = new Konfig();

            konfig.pesanAwal = new PesanAwal();
            konfig.pesanAwal.en = "Please enter your name item: ";
            konfig.pesanAwal.id = "Silahkan masukan nama barang anda: ";

            konfig.diskon = 50;

            konfig.jenisKenaDiskon = new List<string>();
            konfig.jenisKenaDiskon.Add("Keyboard");
            konfig.jenisKenaDiskon.Add("Mouse");
        }
    }

    public class Konfig
    {
        public PesanAwal pesanAwal { get; set; }
        public double diskon { get; set; }
        public List<String> jenisKenaDiskon { get; set; }

        public Konfig() { }
    }

    public class PesanAwal
    {
        public string en { get; set; }
        public string id { get; set; }

        public PesanAwal() { }
    }
}
