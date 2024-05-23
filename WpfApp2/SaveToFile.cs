using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;

namespace WpfApp2
{
    internal class SaveToFile
    {
        private readonly string _fileName;

        public SaveToFile(string fileName)
        {
            _fileName = fileName;
            if (!IsFileExists(_fileName))
            {
                Save(CreateDataSettings());
            }
        }
        public void Save(DataSettings data)
        {
            string json = JsonSerializer.Serialize(data);
            File.WriteAllText(_fileName, json);
        }

        public DataSettings? Read()
        {
            string json = File.ReadAllText(_fileName);
            DataSettings? data = JsonSerializer.Deserialize<DataSettings>(json);
            return data;
        }

        private bool IsFileExists(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            return fileInfo.Exists;
        }

        private DataSettings CreateDataSettings()
        {
            DataSettings data = new DataSettings
            {
                SmalBasePrice = 450f,
                LargeBasePrice = 990f,
                IsSmallType = true,
                OneKmPrice = 35f,
                MarginPercent = 1.12f,
                MaxWeight = 350f,
                SmallDefaultPrices = [700, 900, 1300, 1700],
                LargeDefaultPrices = [1300, 1450, 1850, 2250],
                KmLimits = [5, 10, 20, 30],
                WeightLimits = [25, 50, 100, 300, 500, 2000],
                FloorAscentPrices = [150, 300, 450, 600, 1200, 1800],
                FloorAscentPricesNoElevator = [75, 150, 300, 450, 600, 750],
                AssemblyPercent = 0.09f,
                AssemblyKitchenPercent = 0.14f,
                AssemblyMinPrice = 3150f
            };
            return data;
        }
    }
}
