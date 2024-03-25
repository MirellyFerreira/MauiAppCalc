using Windows.Security.Cryptography.Core;

namespace MauiAppCalc
{
    public partial class MainPage : ContentPage
    {
        string? operacao = null;

        double memoria_calc_pre_operacao = 0;
        double memoria_calc_pos_operacao= 0;

        string para_aparecer_no_visor = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void remover_sinais_visor()
        {
            if (para_aparecer_no_visor == "+" ||
                para_aparecer_no_visor == "-" ||
                para_aparecer_no_visor == "X" ||
                para_aparecer_no_visor == "/");
        }
        private void zerar_Clicked(object sender, EventArgs e)
        {
            visor.Text = "0";
            para_aparecer_no_visor = "";
            memoria_calc_pos_operacao = 0;
            memoria_calc_pos_operacao = 0;
            operacao = null;

        }
        private void maisemenos_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor * -1;
            visor.Text = valor.ToString();
        }
        private void porcento_Clicked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(visor.Text);
            valor = valor / 100;
            visor.Text = valor.ToString();
        }
        private void dividir_Clicked(object sender, EventArgs e)
        {
            memoria_calc_pos_operacao = Convert.ToDouble(visor.Text);
            para_aparecer_no_visor = "/";
            operacao = "/";
            visor.Text = para_aparecer_no_visor;
        }

        private void num7_Clicked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_aparecer_no_visor += num7.Text;
            visor.Text = para_aparecer_no_visor;
        }
        private void num6
    }
}


