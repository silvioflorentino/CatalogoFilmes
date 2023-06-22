using CatalogoFilmes.Controller;
using CatalogoFilmes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoFilmes.View
{
    public partial class TelaCadastroFilme : Form
    {
        public TelaCadastroFilme()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filme.NomeFilme = txBoxFilme.Text;
            Filme.EstreiaFilme = txBoxEstreia.Text;
            Filme.DuracaoFilme = txBoxDuracao.Text;
            Filme.CategoriaFilme = cBoxCategoria.Text;

            FilmeController filmeController = new FilmeController();
            filmeController.CadastrarFilme();

            txBoxFilme.Text = Filme.NomeFilme;
            txBoxEstreia.Text = Filme.EstreiaFilme;
            txBoxDuracao.Text = Filme.DuracaoFilme;
            cBoxCategoria.Text = Filme.CategoriaFilme;

            if (Filme.RetornoFilme == "f")
            {
                this.Close();
            }

        }
        public void FecharTela()
        {
            this.Close();
        }
    }
}
