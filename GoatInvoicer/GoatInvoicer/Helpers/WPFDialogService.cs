using System.Windows;

namespace GoatInvoicer.Helpers
{
    public class WPFDialogService: IDialogService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
