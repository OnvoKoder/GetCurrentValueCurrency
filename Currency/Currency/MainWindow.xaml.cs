using Currency.Class.Managment;
using Currency.Pages;
using System.Windows;
using System.Windows.Navigation;

namespace Currency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            mainFrame.Navigate(new mainPage());
            Manager.MainFrame = mainFrame;
            mainFrame.ContentRendered += (sender, e) => btnBack.Visibility = mainFrame.CanGoBack? Visibility.Visible:Visibility.Hidden;
            btnBack.Click += (sender,e)=>mainFrame.GoBack();
        }
    }
}
