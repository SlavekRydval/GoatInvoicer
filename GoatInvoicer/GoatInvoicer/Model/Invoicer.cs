using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatInvoicer.Model
{
    public class Invoicer: Company
    {
        /// <summary>
        /// IČO
        /// </summary>
        public string IdentifiedNo { get; set; }

        public List<Company> Customers = null;
        public List<Invoice> Invoices = null;


#if DEBUG
        public Invoicer()
        {
            Name = "Fakturuje: DEBUG Ferda Mravenec";
        }
#endif

    }
}
