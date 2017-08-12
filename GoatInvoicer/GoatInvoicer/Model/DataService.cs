using System;

namespace GoatInvoicer.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("Goat the Invoice!", "Running Goat", new Invoicer());
            callback(item, null);
        }
    }
}