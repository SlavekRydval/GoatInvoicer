using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GoatInvoicer.Helpers;
using GoatInvoicer.Model;

namespace GoatInvoicer.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        private readonly IDialogService _dialogService;

        #region WelcomeTitle
        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlepropertyname = nameof (WelcomeTitle);

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }
        #endregion

        #region ApplicationTitle
        /// <summary>
        /// The <see cref="ApplicationTitle" /> property's name.
        /// </summary>
        public const string ApplicationTitlepropertyname = nameof(ApplicationTitle);

        private string _applicationTitle = string.Empty;

        /// <summary>
        /// Gets the ApplicationTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string ApplicationTitle
        {
            get
            {
                return _applicationTitle;
            }
            set
            {
                Set(ref _applicationTitle, value);
            }
        }
        #endregion

        #region Invoicer
        /// <summary>
        /// The <see cref="Invoicer" /> property's name.
        /// </summary>
        public const string Invoicerpropertyname = nameof(Invoicer);

        private Invoicer _invoicer = null;

        /// <summary>
        /// Gets the Invoicer property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public Invoicer Invoicer
        {
            get
            {
                return _invoicer;
            }
            set
            {
                Set(ref _invoicer, value);
            }
        }
        #endregion


        public RelayCommand cmdAbout
        {
            get;
            private set;
        }




        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService, IDialogService dialogService)
        {
            _dialogService = dialogService;

            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                    ApplicationTitle = $"Goat the Invoice, {item.UserName}!";
                    Invoicer = item.Invoicer;
                });


            cmdAbout = new RelayCommand(ExecuteAboutCommand);
        }

        private void ExecuteAboutCommand()
        {
            _dialogService.ShowMessage("O fakturační aplikaci: Zatím ve vývinu");
        }



        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}