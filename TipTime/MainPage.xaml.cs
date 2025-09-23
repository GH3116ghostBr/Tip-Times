﻿namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;
        double porcentagem;
        double valortotal;
        double gorjeta;
        double valorfinal;

        public MainPage()
        {
            InitializeComponent();
            //ValorTotalEntry.Text = "0";
            PorcentagemSlider.Value = 17;


        }


        private void ArredondaCimaBtn_Clicked(object sender, EventArgs e)
        {
            valorfinal = Math.Ceiling(valorfinal);
            ValorFinalLabel.Text = $"R$ {valorfinal}";
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
            valorfinal = Math.Floor(valorfinal);
            ValorFinalLabel.Text = $"R$ {valorfinal}";
            
        }

        private void PorcentagemSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            try 
            {
                porcentagem = PorcentagemSlider.Value;
                PorcentagemGorjetalLabel.Text = $"{porcentagem}%";
                //double gorjeta;
                valortotal = double.Parse(ValorTotalEntry.Text);
                //double valortotal = Convert.ToDouble(ValorTotalEntry.Text);
                //Convert e uma classe
                gorjeta = valortotal * (porcentagem / 100);
                valorfinal = valortotal + gorjeta;
                //estamos interpolando uma varíavel que tem conteudo numero em uma string
                ValorGorjetaLabel.Text = $"R$ {gorjeta}";
                //O recurso de cima não é muito bom
                //O recurso debaixo é melhor porque o caracter c entre aspas determina a 
                //correta moeda de acordo com as configuracoes do sistema operacional e 
                //alem disso faz a aproximação sempre para duas casas decimais porque 
                //sabe que estamos trabalhando valores monetarios
                //ValorGorjetaLabel.Text = Math.Floor(gorjeta.ToString("c"));
                //ValorFinalLabel.Text = Math.Ceiling(valorfinal.ToString("c");
                ValorFinalLabel.Text = $"R$ {valorfinal}";
            }
            catch (Exception ex)
            {
                //Toda vez que uso o comando Console.WriteLine a saída vai para a 
                //console na aba Output
                Console.WriteLine(ex.ToString());
                //O Alert não e eficiente pois quebra a navegação do usuario
                //DisplayAlert("Erro", "Digite um valor numerico", "OK");

            }


        }
    }

}
