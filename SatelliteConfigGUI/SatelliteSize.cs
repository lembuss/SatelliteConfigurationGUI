using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatelliteConfigGUI
{
    public class SatelliteSize
    {
     
        public string WeightGroup { get;  }


        public SatelliteSize(double massPayload)
        {
            this.WeightGroup = DetermineWeightGroup(massPayload);
        }

        public string DetermineWeightGroup(double massPayload)
        {
            string weightGroup = "";

            switch (massPayload)
            {
                case > 1000:
                    weightGroup = "Large";
                    break;

                case > 500:
                    weightGroup = "Medium";
                    break;

                case > 100:
                    weightGroup = "Mini";
                    break;

                case > 10:
                    weightGroup = "Micro";
                    break;

                case > 1:
                    weightGroup = "Nano";
                    break;

                case > 0.1:
                    weightGroup = "Pico";
                    break;

                case > 0:
                    weightGroup = "Femto";
                    break;

                default:
                    break;
            }

            return weightGroup;
        }

    }
}
