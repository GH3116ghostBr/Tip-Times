namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        
        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void Porcentagem15Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 15;
        }

        private void Porcentagem20Btn_Clicked(object sender, EventArgs e)
        {
            PorcentagemSlider.Value = 20;            
        }

        private void ArredondaBaixoBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double porcentagem = PorcentagemSlider.Value;
            double gorjeta;
            double valortotal = float.Parse(ValorTotalEntry.Text);
            float valorfinal;
            gorjeta = valortotal * (porcentagem / 100);
            ValorGorjetaLabel.Text = $"R$ {gorjeta}";

        }
    }

}
