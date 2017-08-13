using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatInvoicer.Model
{
    /// <summary>
    /// Type plátce DPH
    /// </summary>
    public enum UserVATType {
        /// <summary>
        /// Plátce DPH
        /// </summary>
        VATRegistered,
        /// <summary>
        /// Neplátce daně
        /// </summary>
        VATNotRegistered,
        /// <summary>
        /// Identifikovaná osoba, tj. v ČR neplátce DPH, ale při fakturaci do EU musí podávat hlášení o DPH
        /// </summary>
        VATIdentifiedPerson }

    public class Company : ObservableObject
    {
        public string Name { get; set; }
        public string CompanyNo { get; set; }
        public string WebPage { get; set; }
        /// <summary>
        /// TaxNo also known as DIČ
        /// </summary>
        public string TaxNo { get; set; }
        /// <summary>
        /// Typ plátce DPH
        /// </summary>
        public UserVATType VATType { get; set; }


        public BankAccount BankAccount { get; set; } = null; 
    }
}
