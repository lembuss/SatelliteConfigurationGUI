using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatelliteConfigGUI
{
    public class SatelliteConfiguration 
    {
        
        public string Configuration { get; set; }

        public SatelliteConfiguration(string weight, string orbit )
        {
            this.Configuration = GetIdentifier(weight, orbit);
        }

        public string GetIdentifier(string weight, string orbit)
        {
            string sizeIdentifier = weight.Substring(0, 1);
            string orbitIdentifier = orbit.Substring(0, 1);
            string numericalIdentifier;

            if (weight == "Mini")
            {
                numericalIdentifier = "2";
            }
            else if (weight == "Micro")
            {
                numericalIdentifier = "3";
            }
            else
            {
                numericalIdentifier = "1";
            }

            string configuration = sizeIdentifier + orbitIdentifier + numericalIdentifier;

            return configuration;
            
        }

    }
}
