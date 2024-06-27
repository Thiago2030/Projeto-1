namespace Projeto_1
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                if (etanol <= (gasolina * 7.0))

                    Title = "O etanol está compensando";
                else

                    Title = "A gasolina está compensando";

                DisplayAlert("Calculado", Title, "ok");


            }
            catch (Exception ex)
            {

                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        } // Fecha método 
    } // Fecha Class 

} // Fecha namespace 
