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
            new ValveLifterCatalog { Nominal = 3025, Ford = "5103632", Mazda = "LF01-12-542" },
            new ValveLifterCatalog { Nominal = 3050, Ford = "-------", Mazda = "LF01-12-543" },
            new ValveLifterCatalog { Nominal = 3075, Ford = "5103635", Mazda = "LF01-12-544" },
            new ValveLifterCatalog { Nominal = 3100, Ford = "-------", Mazda = "LF01-12-545" },
            new ValveLifterCatalog { Nominal = 3122, Ford = "5103638", Mazda = "LF01-12-546" },
            new ValveLifterCatalog { Nominal = 3142, Ford = "-------", Mazda = "LF01-12-547" },
            new ValveLifterCatalog { Nominal = 3162, Ford = "5103640", Mazda = "LF01-12-548" },
            new ValveLifterCatalog { Nominal = 3182, Ford = "-------", Mazda = "LF01-12-549" },
            new ValveLifterCatalog { Nominal = 3202, Ford = "5103642", Mazda = "LF01-12-551" },
            new ValveLifterCatalog { Nominal = 3222, Ford = "-------", Mazda = "LF01-12-552" },
            new ValveLifterCatalog { Nominal = 3242, Ford = "5103645", Mazda = "LF01-12-553" },
            new ValveLifterCatalog { Nominal = 3262, Ford = "-------", Mazda = "LF01-12-554" },
            new ValveLifterCatalog { Nominal = 3282, Ford = "5103647", Mazda = "LF01-12-555" },
            new ValveLifterCatalog { Nominal = 3302, Ford = "-------", Mazda = "LF01-12-556" },
            new ValveLifterCatalog { Nominal = 3322, Ford = "5103649", Mazda = "LF01-12-557" },
            new ValveLifterCatalog { Nominal = 3342, Ford = "5103650", Mazda = "LF01-12-558" },
            new ValveLifterCatalog { Nominal = 3362, Ford = "5103651", Mazda = "LF01-12-559" },
            new ValveLifterCatalog { Nominal = 3382, Ford = "5103652", Mazda = "LF01-12-561" },
            new ValveLifterCatalog { Nominal = 3402, Ford = "5103653", Mazda = "LF01-12-562" },
            new ValveLifterCatalog { Nominal = 3422, Ford = "5103654", Mazda = "LF01-12-563" },
            new ValveLifterCatalog { Nominal = 3442, Ford = "5103655", Mazda = "LF01-12-564" },
            new ValveLifterCatalog { Nominal = 3462, Ford = "-------", Mazda = "LF01-12-565" },
            new ValveLifterCatalog { Nominal = 3482, Ford = "5103657", Mazda = "LF01-12-566" },
            new ValveLifterCatalog { Nominal = 3502, Ford = "-------", Mazda = "LF01-12-567" },
            new ValveLifterCatalog { Nominal = 3522, Ford = "5103659", Mazda = "LF01-12-568" },
            new ValveLifterCatalog { Nominal = 3542, Ford = "-------", Mazda = "LF01-12-569" },
            new ValveLifterCatalog { Nominal = 3562, Ford = "5103661", Mazda = "LF01-12-571" },
            new ValveLifterCatalog { Nominal = 3582, Ford = "-------", Mazda = "LF01-12-572" },
            new ValveLifterCatalog { Nominal = 3602, Ford = "5103663", Mazda = "LF01-12-573" },
            new ValveLifterCatalog { Nominal = 3625, Ford = "-------", Mazda = "LF01-12-574" },
            new ValveLifterCatalog { Nominal = 3650, Ford = "5103665", Mazda = "LF01-12-575" },
            new ValveLifterCatalog { Nominal = 3675, Ford = "-------", Mazda = "LF01-12-576" },
            new ValveLifterCatalog { Nominal = 3700, Ford = "5103667", Mazda = "LF01-12-577" },
            new ValveLifterCatalog { Nominal = 3725, Ford = "-------", Mazda = "LF01-12-578" }
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
