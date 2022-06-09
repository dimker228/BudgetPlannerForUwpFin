using Windows.UI.Xaml.Controls;
using Budget_Planner.ViewModel;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace budgetplanner.View.PagesView
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class BalancePage : Page
    {
        public BalancePage()
        {
            this.InitializeComponent();
            DataContext = new BalanceViewModel();
        }
    }
}
