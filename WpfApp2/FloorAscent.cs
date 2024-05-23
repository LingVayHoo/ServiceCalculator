using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class FloorAscent
    {
        private float[]? _weightLimits;
        private float[]? _floorAscentPrices;
        private float[]? _floorAscentPricesNoElevator;

        public float[] WeightLimits
        {
            get { return _weightLimits; }
            set { _weightLimits = value == null ? [0, 0, 0, 0, 0, 0] : value; }
        }

        public float[] FloorAscentPrices
        {
            get { return _floorAscentPrices; }
            set { _floorAscentPrices = value == null ? [0, 0, 0, 0, 0, 0] : value; }
        }

        public float[] FloorAscentPricesNoElevator
        {
            get { return _floorAscentPricesNoElevator; }
            set { _floorAscentPricesNoElevator = value == null ? [0, 0, 0, 0, 0, 0] : value; }
        }

        public FloorAscent(DataSettings settings)
        {
            WeightLimits = settings.WeightLimits;
            FloorAscentPrices = settings.FloorAscentPrices;
            FloorAscentPricesNoElevator = settings.FloorAscentPricesNoElevator;
        }

        public float Calculate(bool isElevator, bool isLargeBox, float floorNumber, float weight)
        {
            if (FloorAscentPrices == null) return -1;

            float result = -1;

            if (isElevator) result = PriceWithElevator(weight);
            else result = PriceWithoutElevator(weight, floorNumber);

            if (isLargeBox) result = 1000000;

            return result;
        }

        private float PriceWithElevator(float weight)
        {
            float result = -2;
            for (int i = 0; i < WeightLimits.Length; i++)
            {
                if (weight <= WeightLimits[i])
                {
                    return FloorAscentPrices[i];                    
                }
            }
            return result;
        }

        private float PriceWithoutElevator(float weight, float floorNumber)
        {
            float result = -3;
            for (int i = 0; i < WeightLimits.Length; i++)
            {
                if (weight <= WeightLimits[i])
                {
                    return FloorAscentPricesNoElevator[i] * floorNumber;
                }
            }
            return result;
        }
    }
}
