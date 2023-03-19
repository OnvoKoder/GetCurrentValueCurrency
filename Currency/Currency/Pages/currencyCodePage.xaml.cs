using Currency.Class.Http;
using Currency.Class.Utility;
using System.Windows.Controls;

namespace Currency.Pages
{
    /// <summary>
    /// Interaction logic for currencyCodePage.xaml
    /// </summary>
    public partial class currencyCodePage : Page
    {
        private HttpData http = new HttpData();
        private Switcher switcher = new Switcher();
        public currencyCodePage()
        {
            InitializeComponent();
            cmbCurrencyCode.ItemsSource=http.GetCodeCurrencyInCmb();
            cmbCurrencyCode.SelectionChanged += (sender, e) =>
            {
                lbCurrency.ItemsSource = null;
                lbCurrency.ItemsSource=http.GetCurrentCurrency(switcher.GetCodeValute(cmbCurrencyCode.SelectedIndex));
            };
        }
       
    }
}
