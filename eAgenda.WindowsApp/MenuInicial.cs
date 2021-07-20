using System;
using System.Windows.Forms;

namespace eAgenda.WindowsApp
{
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void btTarefa_Click(object sender, EventArgs e)
        { 
            this.Hide();
            TelaTarefa tarefaForm = new TelaTarefa();
            tarefaForm.ShowDialog();
            this.Close();
        }

        private void btContato_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaContato contatoForm = new TelaContato();
            contatoForm.ShowDialog();
            this.Close();
        }

        private void btCompromisso_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCompromisso compromissoForm = new TelaCompromisso();
            compromissoForm.ShowDialog();
            this.Close();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
