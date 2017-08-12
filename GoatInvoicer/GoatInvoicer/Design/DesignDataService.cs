using System;
using GoatInvoicer.Model;

namespace GoatInvoicer.Design
{
    public class DesignDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data

            var item = new DataItem("Goat Invoicer [design]", "Cheeky Goat", new Invoicer());
            callback(item, null);
        }
    }
}