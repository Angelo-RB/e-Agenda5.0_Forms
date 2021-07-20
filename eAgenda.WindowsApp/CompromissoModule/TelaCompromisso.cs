using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Controladores.ContatoModule;

namespace eAgenda.WindowsApp
{
    public partial class TelaCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();

        private List<Contato> contatos;

        public TelaCompromisso()
        {
            InitializeComponent();
            controladorCompromisso = new ControladorCompromisso();
            contatos = controladorContato.SelecionarTodos();
            CarregarCompromissos();
            PopularCmb();
        }

        private void btVoltarCompromisso_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicial form1 = new MenuInicial();
            form1.ShowDialog();
            this.Close();
        }

        private void btCadastrarCompromisso_Click_1(object sender, EventArgs e)
        {
            AdicionarCompromisso();

            labelRodapeCompromisso.Text = tbAssuntoCompromisso + " Salvo com Sucesso! ";
        }

        private void AdicionarCompromisso()
        {
            string local = tbLocalCompromisso.Text;
            DateTime data = dtpDataCompromisso.Value;
            string assunto = tbAssuntoCompromisso.Text;
            TimeSpan horainicio = TimeSpan.Parse(mtbHoraInicioCompromisso.Text);
            TimeSpan horatermino = TimeSpan.Parse(mtbHoraTerminoCompromisso.Text);
            string link = tbLinkCompromisso.Text;
            Contato contato = contatos.Find(c => c.Nome == (string)cbCompromisso.SelectedItem);

            controladorCompromisso.InserirNovo(new Compromisso(assunto, local, link, data, horainicio, horatermino, contato));

            labelRodapeCompromisso.Text = " Salvo com Sucesso! ";

            CarregarCompromissos();
            LimparCampos();
        }

        private void CarregarCompromissos()
        {
            dtCompromisso.Clear();

            List<Compromisso> carregarCompromissoLista = controladorCompromisso.SelecionarTodos();

            foreach (var compromisso in carregarCompromissoLista)
            {
                DataRow CompromissoRow = dtCompromisso.NewRow();

                CompromissoRow["Id"] = compromisso.Id;
                CompromissoRow["Local"] = compromisso.Local;
                CompromissoRow["Assunto"] = compromisso.Assunto;
                CompromissoRow["Data"] = compromisso.Data.ToShortDateString();
                CompromissoRow["HoraInicio"] = compromisso.HoraInicio;
                CompromissoRow["HoraTermino"] = compromisso.HoraTermino;
                CompromissoRow["Link"] = compromisso.Link;
                CompromissoRow["Contato"] = compromisso.Contato == null ? "Vazio" : compromisso.Contato.Nome;

                dtCompromisso.Rows.Add(CompromissoRow);
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcluirCompromisso();
            LimparCampos();
        }

        private void ExcluirCompromisso()
        {
            int id = Convert.ToInt32(tbIdCompromisso.Text);

            controladorCompromisso.Excluir(id);

            CarregarCompromissos();
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbIdCompromisso.Clear();
            tbLocalCompromisso.Clear();
            tbAssuntoCompromisso.Clear();
            mtbHoraInicioCompromisso.Clear();
            mtbHoraTerminoCompromisso.Clear();
            tbLinkCompromisso.Clear();
            cbCompromisso.ResetText();
        }

        private void btEditarCompromisso_Click(object sender, EventArgs e)
        {
            EditarCompromissos();
        }

        private void EditarCompromissos()
        {
            string local = tbLocalCompromisso.Text;
            DateTime data = dtpDataCompromisso.Value;
            string assunto = tbAssuntoCompromisso.Text;
            TimeSpan horainicio = TimeSpan.Parse(mtbHoraInicioCompromisso.Text);
            TimeSpan horatermino = TimeSpan.Parse(mtbHoraTerminoCompromisso.Text);
            string link = tbLinkCompromisso.Text;

            controladorCompromisso.InserirNovo(new Compromisso(assunto, local, link, data, horainicio, horatermino, null));

            CarregarCompromissos();
            LimparCampos();
        }

        private void PopularCmb()
        {            
            foreach (Contato contato in contatos)
            {
                cbCompromisso.Items.Add(contato.Nome);
            }
        }

        private void tbIdCompromisso_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Campo Id usado somente para editar e excluir! ");
        }

    }
}
