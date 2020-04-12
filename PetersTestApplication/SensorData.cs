using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetersTestApplication
{
    class SensorData
    {
        public string DateTime { get; set; }
            
        public ushort A1_Co2Value { get; set; }
        public float A1A_Temperature { get; set; }
        public float A1A_Humidity { get; set; }
        public float A1B_Temperature { get; set; }
        public float A1B_Humidity { get; set; }

        public ushort A2_Co2Value { get; set; }
        public float A2A_Temperature { get; set; }
        public float A2A_Humidity { get; set; }
        public float A2B_Temperature { get; set; }
        public float A2B_Humidity { get; set; }

        public ushort A3_Co2Value { get; set; }
        public float A3A_Temperature { get; set; }
        public float A3A_Humidity { get; set; }
        public float A3B_Temperature { get; set; }
        public float A3B_Humidity { get; set; }
    }
}

