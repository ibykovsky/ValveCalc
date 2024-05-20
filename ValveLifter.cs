using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValveCalc
{
    

    internal class ValveLifterCatalog
    {
        static ValveLifterCatalog[] catalog = {
            new ValveLifterCatalog { Nominal = 3000, Ford = "5103473", Mazda = "LF01-12-541" },
            new ValveLifterCatalog { Nominal = 3025, Ford = "5103632", Mazda = "LF01-12-544" },
            new ValveLifterCatalog { Nominal = 3075, Ford = "5103635", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3075, Ford = "", Mazda = "LF01-12-545" },
            new ValveLifterCatalog { Nominal = 3122, Ford = "5103638", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3162, Ford = "5103640", Mazda = "LF01-12-548" },
            new ValveLifterCatalog { Nominal = 3202, Ford = "5103642", Mazda = "LF01-12-551" },
            new ValveLifterCatalog { Nominal = 3242, Ford = "5103645", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3282, Ford = "5103647", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3322, Ford = "5103649", Mazda = "LF01-12-552" },
            new ValveLifterCatalog { Nominal = 3342, Ford = "5103650", Mazda = "LF01-12-558" },
            new ValveLifterCatalog { Nominal = 3362, Ford = "5103651", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3382, Ford = "5103652", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3402, Ford = "5103653", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3422, Ford = "5103654", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3442, Ford = "5103655", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3482, Ford = "5103657", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3522, Ford = "5103659", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3562, Ford = "5103661", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3602, Ford = "5103663", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3650, Ford = "5103665", Mazda = "" },
            new ValveLifterCatalog { Nominal = 3700, Ford = "5103667", Mazda = "" }
        };

        //thickness;
        public int Nominal { get; init; }
        public string? Ford { get; init; }
        public string? Mazda { get; init; }

        public ValveLifterCatalog() { }
        public ValveLifterCatalog(int nominal,string ford, string mazda)
        {
            Nominal = nominal;
            Ford = ford;
            Mazda = mazda;
        }
    }

    internal class ValveLifter
    {
        readonly int fact; //thickness;
        readonly ValveLifterCatalog catalog;

        ValveLifter(ValveLifterCatalog catalog, int fact)
        {
            this.catalog = catalog;
            this.fact = fact;
        }
    }
}
