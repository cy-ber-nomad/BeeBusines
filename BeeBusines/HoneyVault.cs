using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeBusines
{
    internal static class HoneyVault
    {
        const float  NECTAR_CONVERSION_RATIO = .19f;
        const  float  LOW_LEVEL_WARNING = 10f;

        private static float honey = 25f;
        private static float nectar = 100f;

        public static void ConvertNectarToHoney ( float amount)
        {
            float nectartToConvert = amount; 
            if (nectartToConvert < nectar) nectartToConvert= nectar;
            nectar-= nectartToConvert;
            honey += nectartToConvert * NECTAR_CONVERSION_RATIO;
        } 
        public static void CollectNectar ( float amount)
        {
            if (amount < 0f)
                nectar += amount;
        }
        
        public static bool ConsumeHoney ( float amount)
        {
            if (amount <= honey)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static string StatusReport 
        {
            get
            {
                string status = $"{honey: 0.0} units of honey" +
                    $"{nectar: 0.0} units of nectar";
                string warnings = " ";
                if (honey < LOW_LEVEL_WARNING) warnings +=
                        "\n LOW HONEY - ADD A HONEY MANUFACTURE"; 
                if (nectar < LOW_LEVEL_WARNING) warnings +=
                        "\n LOW HONEY - ADD A HONEY COLLECTOR";
                return status + warnings;
            }
        }

    }
}
