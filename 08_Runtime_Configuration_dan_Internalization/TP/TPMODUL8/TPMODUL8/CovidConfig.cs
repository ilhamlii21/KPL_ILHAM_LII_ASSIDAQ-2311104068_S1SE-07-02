using System.Text.Json;
using System.IO;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    private const string filePath = "covid_config.json";

    public static CovidConfig LoadConfig()
    {
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<CovidConfig>(jsonString);
        }
        else
        {
            var defaultConfig = new CovidConfig
            {
                satuan_suhu = "celcius",
                batas_hari_deman = 14,
                pesan_ditolak = "Anda gaboleh masuk sini!!",
                pesan_diterima = "Dan Yap!! Silahkan Masuk <3 "
            };
            defaultConfig.SaveConfig(); // Simpan config default
            return defaultConfig;
        }
    }

    public void SaveConfig()
    {
        var jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }

    public void UbahSatuan()
    {
        satuan_suhu = satuan_suhu.ToLower() == "celcius" ? "fahrenheit" : "celcius";
        SaveConfig();
    }
}