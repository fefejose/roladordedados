namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void botao_Clicked(object sender, EventArgs e)
        {
        Random random = new Random();
            int roladorDeDados = random.Next(PickerNumeros.SelectedItem);


            botao.Text = $"Resultado{roladorDeDados}";
        }

        private void botao_Clicked_1(object sender, EventArgs e)
        {

        }
    }

}
