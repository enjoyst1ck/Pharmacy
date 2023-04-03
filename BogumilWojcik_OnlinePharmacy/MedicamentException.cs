using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogumilWojcik_OnlinePharmacy
{
    public class MedicamentException : FormatException
    {
        public MedicamentException(string m) : base(m)
        {

        }
    }
}
