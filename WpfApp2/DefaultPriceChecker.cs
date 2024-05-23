using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class DefaultPriceChecker
    {
        private DataSettings? _settings;

        public DataSettings Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }
        public DefaultPriceChecker(DataSettings settings) 
        { 
            Settings = settings;
        }

        public float Check(bool isSmallType, float km)
        {
            if (_settings == null) return -3; 
            if (km > Settings.KmLimits[3]) return -2;
            float[] defaultPrices;
            if (isSmallType) defaultPrices = Settings.SmallDefaultPrices;
            else defaultPrices = Settings.LargeDefaultPrices;

            float res = -1;
            for (int i = 0; i < Settings.KmLimits.Length; i++)
            {                
                if ( km > 0 )
                {
                    if (i == 0 && km <= Settings.KmLimits[i])
                    {
                        res = defaultPrices[i];
                    }
                    if (i > 0 && km > Settings.KmLimits[i - 1] && km <= Settings.KmLimits[i])
                    {
                        res = defaultPrices[i];
                    }                     
                }
            }
            return res;
            
        }

    }
}
