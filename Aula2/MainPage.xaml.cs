namespace Aula2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_hello_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "Saudações usuário", "Fechar");
        }
    }

}
