using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatInvoicer.Model
{
    public class BankAccount: ObservableObject
    {
        public string Number { get; set; }
        public string Prefix { get; set; }
        public string BankCode { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
        public string NationalFormat { get { return $"{Prefix}-{Number}/{BankCode}"; } }

    }
}
