namespace Table1
{
    public class TableDriven
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

        public string GetNamaElektronik(Elektronik inputnama)
        {
            string[] outputNama = { "Xiaomi 13T", "LG 24Mk", "Samsung Cooler", "ASUS ROG", "Razer", "Viewsonic", "Logitech", "HorzonGamingPC" };
            return outputNama[(int)inputnama];

        }

        public void GetdisplayInfo()
        {
            Elektronik alatElektronik = Elektronik.Smartphone;
            string namaAlat = GetNamaElektronik(alatElektronik);
            Console.WriteLine("Jenis Barang anda merupakan barang " + alatElektronik + " bernama " + namaAlat);
        }
    }
}