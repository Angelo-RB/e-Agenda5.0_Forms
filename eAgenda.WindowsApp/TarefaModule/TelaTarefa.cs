using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using eAgenda.WindowsApp.TarefaModule;

namespace eAgenda.WindowsApp
{
    public partial class TelaTarefa : Form
    {
        ControladorTarefa controladorTarefa = new ControladorTarefa();

        public TelaTarefa()
        {
            InitializeComponent();
            controladorTarefa = new ControladorTarefa();
            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();
        }

        private int DefinirPrioridade(object selectedItem)
        {
            switch (selectedItem.ToString())
            {
                case "Prioridade Alta": return 2;
                case "Prioridade Normal": return 1;
                case "Prioridade Baixa": return 0;
            }
            return 0;
        }

        private void btVoltarTarefa_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicial form1 = new MenuInicial();
            form1.ShowDialog();
            this.Close();
        }

        private void btCadastrarTarefa_Click_1(object sender, EventArgs e)
        {
            AdicionarTarefa();
        }
        private void AdicionarTarefa() 
        {
            string titulo = tbTituloTarefa.Text;
            int prioridade = Convert.ToInt32(cbPrioridadeTarefa.SelectedIndex);

            labelRodapeTarefa.Text = " Salva com Sucesso! ";

            controladorTarefa.InserirNovo(new Tarefa(titulo, DateTime.Now, (PrioridadeEnum)prioridade));

            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();
            LimparCampos();
        }

        private void CarregarTarefasPendentes()
        {
            dtTarefaPendentes.Clear();

            List<Tarefa> carregarTarefasListaPendentes = controladorTarefa.SelecionarTodasTarefasPendentes();

            foreach (var tarefa in carregarTarefasListaPendentes)
            {
                DataRow tarefaRow = dtTarefaPendentes.NewRow();

                tarefaRow["Id"] = tarefa.Id;
                tarefaRow["Titulo"] = tarefa.Titulo;
                tarefaRow["DataCriacao"] = tarefa.DataCriacao.ToShortDateString();
                tarefaRow["Prioridade"] = tarefa.Prioridade;
                tarefaRow["Percentual"] = tarefa.Percentual;

                dtTarefaPendentes.Rows.Add(tarefaRow);
            }
        }

        private void CarregarTarefasConcluidas()
        {
            dtTarefaConcluidas.Clear();

            List<Tarefa> carregarTarefasListaConcluidas = controladorTarefa.SelecionarTodasTarefasConcluidas();

            foreach (var tarefa in carregarTarefasListaConcluidas)
            {
                DataRow tarefaRow = dtTarefaConcluidas.NewRow();

                tarefaRow["Id"] = tarefa.Id;
                tarefaRow["Titulo"] = tarefa.Titulo;
                tarefaRow["DataCriacao"] = tarefa.DataCriacao.ToShortDateString();
                tarefaRow["Prioridade"] = tarefa.Prioridade;
                tarefaRow["Percentual"] = tarefa.Percentual;

                dtTarefaConcluidas.Rows.Add(tarefaRow);
            }
        }

        private void btExcluirTarefa_Click_1(object sender, EventArgs e)
        {
            ExcluirTarefa();
            LimparCampos();
        }

        private void ExcluirTarefa()
        {
            int id = Convert.ToInt32(tbIdTarefa.Text);

            controladorTarefa.Excluir(id);

            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();
            LimparCampos();
        }

        private void LimparCampos()
        {
            tbIdTarefa.Clear();
            tbTituloTarefa.Clear();
            tbPercentual.Clear();
        }

        private void btEditarTarefa_Click(object sender, EventArgs e)
        {
            EditarTarefa();
        }

        private void EditarTarefa()
        {
            int id = Convert.ToInt32(tbIdTarefa.Text);
            string titulo = tbTituloTarefa.Text;
            int prioridade = DefinirPrioridade(cbPrioridadeTarefa.SelectedItem);
            DateTime datacriacao = dtpDataTarefaCriacao.Value;

            Tarefa tarefa = new Tarefa(titulo, datacriacao, (PrioridadeEnum)prioridade);
            tarefa.AtualizarPercentual(Convert.ToInt32(tbPercentual.Text), DateTime.Now);

            controladorTarefa.Editar(id, tarefa);

            CarregarTarefasPendentes();
            CarregarTarefasConcluidas();
            LimparCampos();
        }

        private void tbIdTarefa_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Campo Id usado somente para editar e excluir! ");
        }
    }
}
