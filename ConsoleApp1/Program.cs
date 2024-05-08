using Class1;
using Table1;


internal class Program
{
    static void Main(string[] args)
    {
        Inventaris inventarisBarang = new Inventaris();


        inventarisBarang.TambahStokBarang("Laptop", 01, 10, 150000, "Elektronik");
        inventarisBarang.TambahStokBarang("SmartPhone", 02, 50, 20000, "Elektronik");
        inventarisBarang.TambahStokBarang("Keyboard", 03, 15, 70000, "Elektronik");

        inventarisBarang.TampilkanInventaris();

        inventarisBarang.HapusBarang("Keyboard", 03, 15, 70000, "Elektronik");
        Console.WriteLine("============= Barang berhasil dihapus =================");
        Console.WriteLine("");

        inventarisBarang.TampilkanInventaris();

        TableDriven tableDriven = new TableDriven();
        tableDriven.GetdisplayInfo();
    }

}