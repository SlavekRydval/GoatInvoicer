using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatInvoicer.Model
{
    public class Invoice: ObservableObject
    {
        public DateTime CreatedAt { get; set; }
        public DateTime DueDate { get; set; }
    }
}
