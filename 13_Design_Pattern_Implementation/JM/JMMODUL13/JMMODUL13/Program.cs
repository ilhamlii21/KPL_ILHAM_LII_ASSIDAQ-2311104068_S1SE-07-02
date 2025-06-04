using JMMODUL13;
public class Program
{
    public static void Main(string[] args)
    {
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        data1.AddSebuahData("Ilham");
        data1.AddSebuahData("Christoper");
        data1.AddSebuahData("William");

        Console.WriteLine("Data di data2:");
        data2.PrintSemuaData();

        data2.HapusSebuahData(2);

        Console.WriteLine("\nSetelah penghapusan, data di data1:");
        data1.PrintSemuaData();

        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData().Count}");
    }
}