using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class DataSettings
    {
        private float _smalBasePrice;
        private float _largeBasePrice;
        private float _oneKmPrice;
        private float _marginPercent;
        private float _maxWeight;
        private float[]? _smallDefaultPrices;
        private float[]? _largeDefaultPrices;
        private float[]? _kmLimits;
        private float[]? _weightLimits;
        private float[]? _floorAscentPrices;
        private float[]? _floorAscentPricesNoElevator;
        private float _assemblyPercent;
        private float _assemblyKitchenPercent;
        private float _assemblyMinPrice;
        private bool _isSmallType;




        public float SmalBasePrice
        {
            get { return _smalBasePrice; }
            set { _smalBasePrice = value; }
        }

        public float LargeBasePrice
        {
            get { return _largeBasePrice; }
            set { _largeBasePrice = value; }
        }

        public bool IsSmallType
        {
            get { return _isSmallType; }
            set { _isSmallType = value; }
        }

        public float OneKmPrice
        {
            get { return _oneKmPrice; }
            set { _oneKmPrice = value; }
        }

        public float MarginPercent
        {
            get { return _marginPercent; }
            set { _marginPercent = value; }
        }

        public float MaxWeight
        { 
            get { return _maxWeight; }
            set { _maxWeight = value; } 
        }

        public float[] SmallDefaultPrices 
        { 
            get { return _smallDefaultPrices; }
            set { _smallDefaultPrices = value == null ? [0, 0, 0, 0] : value; }
        }

        public float[] LargeDefaultPrices
        {
            get { return _largeDefaultPrices; }
            set { _largeDefaultPrices = value == null ? [0, 0, 0, 0] : value; }
        }

        public float[] KmLimits
        {
            get { return _kmLimits; }
            set { _kmLimits = value == null ? [0, 0, 0, 0] : value; }
        }
        public float[] WeightLimits
        {
            get { return _weightLimits; }
            set { _weightLimits = value ?? ([0, 0, 0, 0, 0, 0]); }
        }
        public float[] FloorAscentPrices
        {
            get { return _floorAscentPrices; }
            set { _floorAscentPrices = value ?? ([0, 0, 0, 0, 0, 0]); }
        }

        public float[] FloorAscentPricesNoElevator
        {
            get { return _floorAscentPricesNoElevator; }
            set { _floorAscentPricesNoElevator = value ?? ([0, 0, 0, 0, 0, 0]); }
        }

        public float AssemblyPercent { get => _assemblyPercent; set => _assemblyPercent = value; }
        public float AssemblyKitchenPercent { get => _assemblyKitchenPercent; set => _assemblyKitchenPercent = value; }
        public float AssemblyMinPrice { get => _assemblyMinPrice; set => _assemblyMinPrice = value; }
    }
}
