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
            WebPage = "http://www.rydval.cz";
            BankAccount = new BankAccount();
            BankAccount.Prefix = "670100";
            BankAccount.Number = "2211319993";
            BankAccount.BankCode = "6210";
            BankAccount.IBAN = "CZ05 6210 6701 0022 1131 9993";
            BankAccount.BIC = "BREXCZPPXXX";
        }
#endif

    }
}
