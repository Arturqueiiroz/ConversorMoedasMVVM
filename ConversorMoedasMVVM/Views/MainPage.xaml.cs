using ConversorMoedasMVVM.ViewModels;
namespace ConversorMoedasMVVM
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
