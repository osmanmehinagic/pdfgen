using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportGenerator.DataObjects.CustomExceptions
{
    public static class CustomExceptionMessages
    {
        //configuration
        public static string invalidConfiguration = "Neispravna konfiguracija";

        //GUI validations
        public static string numberOfRowsMandatory = "Broj redova je obavezno polje";
        public static string numberOfRowsInteger = "Broj redova mora biti broj!";
        public static string numberOfRowsPositiveInteger = "Broj redova mora biti pozitivan broj!";

        //BL validations
        public static string emptyList = "Lista prazna";
        public static string applicationProcessingLimitExceeded = "Kreiranje PDF reporta u toku, pokušajte ponovo za par mintua!";
    }
}
