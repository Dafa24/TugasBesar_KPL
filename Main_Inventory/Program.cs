using Main_Inventory;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Gudang newGudang = new Gudang();

        newGudang.cariBarang("Ipad");

    }
}