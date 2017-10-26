using System;
using System.Windows.Forms;

namespace CarrinhasApp
{
    public partial class FormCarrinhas : Form
    {
        public FormCarrinhas()
        {
            InitializeComponent();

            this.userControlCarrinha1.BotaoClickHandler(new EventHandler(QuandoBotaoUserControloCarrinha1Pressionado));
            this.userControlCarrinha2.BotaoClickHandler(new EventHandler(QuandoBotaoUserControloCarrinha2Pressionado));
        }

        private void QuandoBotaoUserControloCarrinha1Pressionado(object sender, EventArgs e)
        {
            string strLivres = userControlCarrinha1.NumLugaresLivres.ToString();
            string strReservados = userControlCarrinha1.NumLugaresReservados.ToString();

            labelLugaresLivresCarrinha1.Text = "Lugares Livres: " + strLivres;
            labelLugaresReservadosCarrinha1.Text = "Lugares Reservados: " + strReservados;


            if (userControlCarrinha1.MotoristaAtribuido)
            {
                labelMotoristaCarrinha1.Text = "Motorista: Sim";    
            }
            else
            {
                labelMotoristaCarrinha1.Text = "Motorista: Não";
            }
            
        }


        private void QuandoBotaoUserControloCarrinha2Pressionado(object sender, EventArgs e)
        {
            string strLivres = userControlCarrinha2.NumLugaresLivres.ToString();
            string strReservados = userControlCarrinha2.NumLugaresReservados.ToString();

            labelLugaresLivresCarrinha2.Text = "Lugares Livres: " + strLivres;
            labelLugaresReservadosCarrinha2.Text = "Lugares Reservados: " + strReservados;


            if (userControlCarrinha2.MotoristaAtribuido)
            {
                labelMotoristaCarrinha2.Text = "Motorista: Sim";
            }
            else
            {
                labelMotoristaCarrinha2.Text = "Motorista: Não";
            }

        }




    }
}
