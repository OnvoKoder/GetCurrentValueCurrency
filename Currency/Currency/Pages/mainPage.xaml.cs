using Currency.Class.Managment;
using System.Windows.Controls;

namespace Currency.Pages
{
    /// <summary>
    /// Interaction logic for mainPage.xaml
    /// </summary>
    public partial class mainPage : Page
    {
        public mainPage()
        {
            InitializeComponent();
            btnCurrencyName.Click += (sender, e) => Manager.MainFrame.Navigate(new currencyNamePage());
            btnCurrencyCode.Click += (sender, e) => Manager.MainFrame.Navigate(new currencyCodePage());
        }
    }
}
