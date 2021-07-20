using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Controladores.ContatoModule;

namespace eAgenda.WindowsApp
{
    public partial class TelaContato : Form
    {
        ControladorContato controladorContato = new ControladorContato();

        public TelaContato()
        {
            InitializeComponent();
            controladorContato = new ControladorContato();
            CarregarContatos();
        }

        private void btVoltarContato_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicial form1 = new MenuInicial();
            form1.ShowDialog();
            this.Close();
        }

        private void btCadastrarContato_Click_1(object sender, EventArgs e)
        {
            AdicionarContato();
        }

        private void AdicionarContato() 
        {
            string nome = tbNomeContato.Text;
            string email = tbEmailContato.Text;
            string telefone = mtbTelefoneContato.Text;
            string cargo = tbCargoContato.Text;
            string empresa = tbEmpresaContato.Text;

            controladorContato.InserirNovo(new Contato(nome, email, telefone, empresa, cargo));

            labelRodapeContato.Text = " Salvo com Sucesso! ";

            CarregarContatos();
            LimparCampos();
        }

        private void CarregarContatos() 
        {
            dtContato.Clear();

            List<Contato> carregarContatosLista = controladorContato.SelecionarTodos();

            foreach (var contato in carregarContatosLista)
            {
                DataRow contatoRow = dtContato.NewRow();

                contatoRow["Id"] = contato.Id;
                contatoRow["Nome"] = contato.Nome; 
                contatoRow["Email"] = contato.Email;
                contatoRow["Telefone"] = contato.Telefone;
                contatoRow["Cargo"] = contato.Cargo;
                contatoRow["Empresa"] = contato.Empresa;

                dtContato.Rows.Add(contatoRow);
            }
        }        

        private void btExcluirContato_Click_1(object sender, EventArgs e)
        {
            ExcluirContato();
            LimparCampos();
        }

        private void ExcluirContato()
        {
            int id = Convert.ToInt32(tbIdContato.Text);

            controladorContato.Excluir(id);

            CarregarContatos();
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbIdContato.Clear();
            tbNomeContato.Clear();
            tbEmailContato.Clear();
            mtbTelefoneContato.Clear();
            tbCargoContato.Clear();
            tbEmpresaContato.Clear();
        }

        private void btEditarComtato_Click(object sender, EventArgs e)
        {
            EditarContato();
        }

        private void EditarContato()
        {
            int id = Convert.ToInt32(tbIdContato.Text);
            string nome = tbNomeContato.Text;
            string email = tbEmailContato.Text;
            string telefone = mtbTelefoneContato.Text;
            string cargo = tbCargoContato.Text;
            string empresa = tbEmpresaContato.Text;

            controladorContato.Editar(id, new Contato( nome, email, telefone, empresa, cargo));

            CarregarContatos();
            LimparCampos();
        }

        private void tbIdContato_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Campo Id usado somente para editar e excluir! ");
        }
    }
}
