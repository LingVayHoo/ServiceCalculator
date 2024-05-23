using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2;

namespace ServiceCalculator
{

    internal class AssemblyCalculator
    {
        private DataSettings? _settings;

        internal DataSettings? Settings { get => _settings; set => _settings = value; }

        public AssemblyCalculator(DataSettings settings)
        {
            Settings = settings;
        }
                
        public float Calculate(bool isKitchen, float goodsCost)
        {
            if (Settings == null) return -1f;
            float percent = 0;
            if (isKitchen) percent = Settings.AssemblyKitchenPercent;
            else percent = Settings.AssemblyPercent;

            float result = goodsCost * percent;
            result *= Settings.MarginPercent;
            // Проверка на минимальную стоимость
            if (result < Settings.AssemblyMinPrice) result = Settings.AssemblyMinPrice;

            return result;
        }
    }
}
