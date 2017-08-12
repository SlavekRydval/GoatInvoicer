namespace GoatInvoicer.Model
{
    public class DataItem
    {
        public string Title
        {
            get;
            private set;
        }

        public string UserName
        {
            get;
            private set;

        }

        public Invoicer Invoicer
        {
            get;
            private set;
        }

        public DataItem(string title, string userName, Invoicer invoicer)
        {
            Title = title;
            UserName = userName;
            Invoicer = invoicer;
        }
    }
}