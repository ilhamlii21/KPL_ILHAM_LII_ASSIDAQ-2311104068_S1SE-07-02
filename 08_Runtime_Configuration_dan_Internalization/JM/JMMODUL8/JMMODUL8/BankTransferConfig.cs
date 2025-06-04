using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JMMODUL8
{
    public class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }

        private const string filePath = "bank_transfer_config.json";

        public static BankTransferConfig LoadConfig()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<BankTransferConfig>(json);
            }
            else
            {
                var defaultConfig = new BankTransferConfig
                {
                    lang = "en",
                    transfer = new Transfer { threshold = 25000000, low_fee = 6500, high_fee = 15000 },
                    methods = new List<string> { "RTO (real-time)", "SKN", "RTGS", "BI FAST" },
                    confirmation = new Confirmation { en = "yes", id = "ya" }
                };
                defaultConfig.SaveConfig();
                return defaultConfig;
            }
        }

        public void SaveConfig()
        {
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }

    public class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    public class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }
}
