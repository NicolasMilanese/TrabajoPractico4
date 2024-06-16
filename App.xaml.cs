namespace TrabajoPractico3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage= new NavigationPage(new Principal());

            navPage.BarBackground = Color.FromHex("#221f1f");
            navPage.BarTextColor = Colors.White;
            MainPage = navPage;
        }
    }
}
