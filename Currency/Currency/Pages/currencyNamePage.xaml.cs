using Currency.Class.Http;
using Currency.Class.Utility;
using System.Windows.Controls;

namespace Currency.Pages
{
    /// <summary>
    /// Interaction logic for currencyNamePage.xaml
    /// </summary>
    public partial class currencyNamePage : Page
    {
        private HttpData http = new HttpData();
        private Switcher switcher = new Switcher();
        public currencyNamePage()
        {
            InitializeComponent();
            cmbCurrencyName.ItemsSource = http.GetNameCurrencyInCmb();
            cmbCurrencyName.SelectionChanged += (sender, e) =>
            {
                lbCurrency.ItemsSource = null;
                lbCurrency.ItemsSource = http.GetCurrentCurrency(switcher.GetCodeValute(cmbCurrencyName.SelectedIndex));
            };
        }
    }
}
