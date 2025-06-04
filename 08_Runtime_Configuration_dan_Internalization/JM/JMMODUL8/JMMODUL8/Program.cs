using System;
using JMMODUL8;

class Program
{
    static void Main()
    {
        BankTransferConfig config = BankTransferConfig.LoadConfig();

        Console.WriteLine("==== Bank Transfer Application ====");
        Console.Write(config.lang == "en" ? "Please insert the amount of money to transfer:\n>> " :
        "Masukkan jumlah uang yang akan di-transfer:\n>> ");
        int amount = Convert.ToInt32(Console.ReadLine());

        int fee = (amount <= config.transfer.threshold) ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        Console.WriteLine(config.lang == "en"
            ? $"Transfer fee = {fee}\nTotal amount = {total}"
            : $"Biaya transfer = {fee}\nTotal biaya = {total}");

        Console.WriteLine();
        Console.WriteLine(config.lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.Write(config.lang == "en"
            ? $"\nPlease type \"{config.confirmation.en}\" to confirm the transaction:\n>> "
            : $"\nKetik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi:\n>> ");
        string confirm = Console.ReadLine();

        if ((config.lang == "en" && confirm == config.confirmation.en) ||
            (config.lang == "id" && confirm == config.confirmation.id))
        {
            Console.WriteLine(config.lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(config.lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}