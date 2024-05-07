internal class Parameterization_Generics
{
  private static void Main(string[] args)
  {
     ListData<int, string> ObjData1 = new ListData<string, int, int, int>("Keyboard", 110, 10, 59000);
     ObjData1.PrintData();
  }
}

class ListData<NamaBarang, KodeBarang, JumlahBarang, HargaBarang>
{
  private NamaBarang data1;
  private KodeBarang data2;
  private JumlahBarang data3;
  private HargaBarang data4;

  public ListData(NamaBarang InputData1, KodeBarang InputData2, JumlahBarang InputData3, HargaBarang InputData4)
  {
     data1 = InputData1;
     data2 = InputData2;
     data3 = InputData3;
     data4 = InputData4;
  }

  public void PrintData()
  {
     Console.WriteLine("Data 1 adalah: " + data1 + " dan Data 2 adalah: " + data2 + " dan Data 3 adalah: " + data3 + " dan Data 4 adalah: " + data4);
  }
}
