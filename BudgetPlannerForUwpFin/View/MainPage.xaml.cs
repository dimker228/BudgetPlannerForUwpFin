using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using budgetplanner.View.PagesView;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace budgetplanner
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        HistoryPage historyPage;
        BalancePage balancePage;
        AddOperationPage addOperationPage;
        public MainPage()
        {
            this.InitializeComponent();
            historyPage = new HistoryPage();
            balancePage = new BalancePage();
            addOperationPage = new AddOperationPage();
        }
        private void NavigationViewItem_NavigateToBalanse(object sender, TappedRoutedEventArgs e)
        {
            NavigatedFrame.Content = balancePage;
        }

        private void NavigationViewItem_NavigateToHistory(object sender, TappedRoutedEventArgs e)
        {
            NavigatedFrame.Content = historyPage;
        }

        private void NavigationViewItem_NavigateToNewOpperation(object sender, TappedRoutedEventArgs e)
        {
            NavigatedFrame.Content = addOperationPage;
        }
    }
}
