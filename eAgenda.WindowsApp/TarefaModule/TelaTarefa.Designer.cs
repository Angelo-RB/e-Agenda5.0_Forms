
namespace eAgenda.WindowsApp
{
    partial class TelaTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTarefa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTituloTarefa = new System.Windows.Forms.TextBox();
            this.cbPrioridadeTarefa = new System.Windows.Forms.ComboBox();
            this.dtpDataTarefaCriacao = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPercentual = new System.Windows.Forms.TextBox();
            this.tbIdTarefa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTarefasPendentes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dtTarefaPendentes = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dtTarefaConcluidas = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelButons = new System.Windows.Forms.Panel();
            this.btVoltarTarefa = new System.Windows.Forms.Button();
            this.btExcluirTarefa = new System.Windows.Forms.Button();
            this.btEditarTarefa = new System.Windows.Forms.Button();
            this.btCadastrarTarefa = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTituloBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodapeTarefa = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvTarefasConcluidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataTarefaConclusao = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefaPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefaConcluidas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panelButons.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTituloBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasConcluidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAREFA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prioridade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Criação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Percentual:";
            // 
            // tbTituloTarefa
            // 
            this.tbTituloTarefa.Location = new System.Drawing.Point(133, 8);
            this.tbTituloTarefa.Name = "tbTituloTarefa";
            this.tbTituloTarefa.Size = new System.Drawing.Size(148, 20);
            this.tbTituloTarefa.TabIndex = 9;
            // 
            // cbPrioridadeTarefa
            // 
            this.cbPrioridadeTarefa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioridadeTarefa.FormattingEnabled = true;
            this.cbPrioridadeTarefa.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.cbPrioridadeTarefa.Location = new System.Drawing.Point(441, 8);
            this.cbPrioridadeTarefa.Name = "cbPrioridadeTarefa";
            this.cbPrioridadeTarefa.Size = new System.Drawing.Size(89, 21);
            this.cbPrioridadeTarefa.TabIndex = 13;
            // 
            // dtpDataTarefaCriacao
            // 
            this.dtpDataTarefaCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTarefaCriacao.Location = new System.Drawing.Point(133, 36);
            this.dtpDataTarefaCriacao.Name = "dtpDataTarefaCriacao";
            this.dtpDataTarefaCriacao.Size = new System.Drawing.Size(89, 20);
            this.dtpDataTarefaCriacao.TabIndex = 16;
            this.dtpDataTarefaCriacao.Value = new System.DateTime(2021, 7, 19, 15, 30, 42, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.dtpDataTarefaConclusao);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbPercentual);
            this.groupBox3.Controls.Add(this.tbIdTarefa);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbTituloTarefa);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpDataTarefaCriacao);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbPrioridadeTarefa);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(158, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 98);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // tbPercentual
            // 
            this.tbPercentual.Location = new System.Drawing.Point(441, 40);
            this.tbPercentual.Name = "tbPercentual";
            this.tbPercentual.Size = new System.Drawing.Size(89, 20);
            this.tbPercentual.TabIndex = 20;
            // 
            // tbIdTarefa
            // 
            this.tbIdTarefa.Location = new System.Drawing.Point(441, 68);
            this.tbIdTarefa.Name = "tbIdTarefa";
            this.tbIdTarefa.Size = new System.Drawing.Size(89, 20);
            this.tbIdTarefa.TabIndex = 19;
            this.tbIdTarefa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbIdTarefa_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(396, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Id:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(151, 190);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 206);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTarefasPendentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarefas Pendentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTarefasPendentes
            // 
            this.dgvTarefasPendentes.AutoGenerateColumns = false;
            this.dgvTarefasPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefasPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvTarefasPendentes.DataMember = "dtTarefaPendentes";
            this.dgvTarefasPendentes.DataSource = this.dataSet1;
            this.dgvTarefasPendentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefasPendentes.Location = new System.Drawing.Point(3, 3);
            this.dgvTarefasPendentes.Name = "dgvTarefasPendentes";
            this.dgvTarefasPendentes.Size = new System.Drawing.Size(648, 174);
            this.dgvTarefasPendentes.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataCriacao";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataCriacao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Prioridade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Prioridade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Percentual";
            this.dataGridViewTextBoxColumn5.HeaderText = "Percentual";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTarefaPendentes,
            this.dtTarefaConcluidas});
            // 
            // dtTarefaPendentes
            // 
            this.dtTarefaPendentes.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dtTarefaPendentes.TableName = "dtTarefaPendentes";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Titulo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "DataCriacao";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Prioridade";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Percentual";
            // 
            // dtTarefaConcluidas
            // 
            this.dtTarefaConcluidas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11});
            this.dtTarefaConcluidas.TableName = "dtTarefaConcluidas";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Id";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Titulo";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "DataCriacao";
            this.dataColumn8.ColumnName = "DataCriacao";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "DataConclusao";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Prioridade";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Percentual";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTarefasConcluidas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarefas Concluidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelButons
            // 
            this.panelButons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelButons.Controls.Add(this.btVoltarTarefa);
            this.panelButons.Controls.Add(this.btExcluirTarefa);
            this.panelButons.Controls.Add(this.btEditarTarefa);
            this.panelButons.Controls.Add(this.btCadastrarTarefa);
            this.panelButons.Controls.Add(this.panelLogo);
            this.panelButons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButons.Location = new System.Drawing.Point(0, 0);
            this.panelButons.Name = "panelButons";
            this.panelButons.Size = new System.Drawing.Size(149, 421);
            this.panelButons.TabIndex = 27;
            // 
            // btVoltarTarefa
            // 
            this.btVoltarTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltarTarefa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVoltarTarefa.FlatAppearance.BorderSize = 0;
            this.btVoltarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTarefa.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btVoltarTarefa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btVoltarTarefa.Location = new System.Drawing.Point(0, 320);
            this.btVoltarTarefa.Name = "btVoltarTarefa";
            this.btVoltarTarefa.Size = new System.Drawing.Size(149, 101);
            this.btVoltarTarefa.TabIndex = 23;
            this.btVoltarTarefa.Text = "Menu Inicial";
            this.btVoltarTarefa.UseVisualStyleBackColor = true;
            this.btVoltarTarefa.Click += new System.EventHandler(this.btVoltarTarefa_Click_1);
            // 
            // btExcluirTarefa
            // 
            this.btExcluirTarefa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btExcluirTarefa.FlatAppearance.BorderSize = 0;
            this.btExcluirTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirTarefa.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btExcluirTarefa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btExcluirTarefa.Location = new System.Drawing.Point(0, 240);
            this.btExcluirTarefa.Name = "btExcluirTarefa";
            this.btExcluirTarefa.Size = new System.Drawing.Size(149, 80);
            this.btExcluirTarefa.TabIndex = 22;
            this.btExcluirTarefa.Text = "Excluir";
            this.btExcluirTarefa.UseVisualStyleBackColor = true;
            this.btExcluirTarefa.Click += new System.EventHandler(this.btExcluirTarefa_Click_1);
            // 
            // btEditarTarefa
            // 
            this.btEditarTarefa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEditarTarefa.FlatAppearance.BorderSize = 0;
            this.btEditarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarTarefa.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btEditarTarefa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btEditarTarefa.Location = new System.Drawing.Point(0, 160);
            this.btEditarTarefa.Name = "btEditarTarefa";
            this.btEditarTarefa.Size = new System.Drawing.Size(149, 80);
            this.btEditarTarefa.TabIndex = 21;
            this.btEditarTarefa.Text = "Editar";
            this.btEditarTarefa.UseVisualStyleBackColor = true;
            this.btEditarTarefa.Click += new System.EventHandler(this.btEditarTarefa_Click);
            // 
            // btCadastrarTarefa
            // 
            this.btCadastrarTarefa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastrarTarefa.FlatAppearance.BorderSize = 0;
            this.btCadastrarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarTarefa.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btCadastrarTarefa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btCadastrarTarefa.Location = new System.Drawing.Point(0, 80);
            this.btCadastrarTarefa.Name = "btCadastrarTarefa";
            this.btCadastrarTarefa.Size = new System.Drawing.Size(149, 80);
            this.btCadastrarTarefa.TabIndex = 19;
            this.btCadastrarTarefa.Text = "Cadastrar";
            this.btCadastrarTarefa.UseVisualStyleBackColor = true;
            this.btCadastrarTarefa.Click += new System.EventHandler(this.btCadastrarTarefa_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.label7);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(149, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eAgenda.WindowsApp.Properties.Resources.CadastrarIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(42, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "e-Agenda";
            // 
            // panelTituloBar
            // 
            this.panelTituloBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(60)))), ((int)(((byte)(189)))));
            this.panelTituloBar.Controls.Add(this.pictureBox2);
            this.panelTituloBar.Controls.Add(this.label1);
            this.panelTituloBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloBar.Location = new System.Drawing.Point(149, 0);
            this.panelTituloBar.Name = "panelTituloBar";
            this.panelTituloBar.Size = new System.Drawing.Size(676, 80);
            this.panelTituloBar.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eAgenda.WindowsApp.Properties.Resources.assignment;
            this.pictureBox2.Location = new System.Drawing.Point(233, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodapeTarefa});
            this.statusStrip1.Location = new System.Drawing.Point(149, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodapeTarefa
            // 
            this.labelRodapeTarefa.ForeColor = System.Drawing.Color.White;
            this.labelRodapeTarefa.Name = "labelRodapeTarefa";
            this.labelRodapeTarefa.Size = new System.Drawing.Size(82, 17);
            this.labelRodapeTarefa.Text = "Aguardando...";
            // 
            // dgvTarefasConcluidas
            // 
            this.dgvTarefasConcluidas.AutoGenerateColumns = false;
            this.dgvTarefasConcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefasConcluidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataConclusaoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvTarefasConcluidas.DataMember = "dtTarefaConcluidas";
            this.dgvTarefasConcluidas.DataSource = this.dataSet1;
            this.dgvTarefasConcluidas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefasConcluidas.Location = new System.Drawing.Point(3, 3);
            this.dgvTarefasConcluidas.Name = "dgvTarefasConcluidas";
            this.dgvTarefasConcluidas.Size = new System.Drawing.Size(648, 174);
            this.dgvTarefasConcluidas.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DataCriacao";
            this.dataGridViewTextBoxColumn8.HeaderText = "DataCriacao";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataConclusaoDataGridViewTextBoxColumn
            // 
            this.dataConclusaoDataGridViewTextBoxColumn.DataPropertyName = "DataConclusao";
            this.dataConclusaoDataGridViewTextBoxColumn.HeaderText = "DataConclusao";
            this.dataConclusaoDataGridViewTextBoxColumn.Name = "dataConclusaoDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Prioridade";
            this.dataGridViewTextBoxColumn9.HeaderText = "Prioridade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Percentual";
            this.dataGridViewTextBoxColumn10.HeaderText = "Percentual";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data Conclusão:";
            // 
            // dtpDataTarefaConclusao
            // 
            this.dtpDataTarefaConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTarefaConclusao.Location = new System.Drawing.Point(133, 68);
            this.dtpDataTarefaConclusao.Name = "dtpDataTarefaConclusao";
            this.dtpDataTarefaConclusao.Size = new System.Drawing.Size(89, 20);
            this.dtpDataTarefaConclusao.TabIndex = 22;
            this.dtpDataTarefaConclusao.Value = new System.DateTime(2021, 7, 19, 15, 30, 42, 0);
            // 
            // TelaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelTituloBar);
            this.Controls.Add(this.panelButons);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefaPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefaConcluidas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panelButons.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTituloBar.ResumeLayout(false);
            this.panelTituloBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefasConcluidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTituloTarefa;
        private System.Windows.Forms.ComboBox cbPrioridadeTarefa;
        private System.Windows.Forms.DateTimePicker dtpDataTarefaCriacao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbIdTarefa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentualDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtTarefaPendentes;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataTable dtTarefaConcluidas;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dgvTarefasPendentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panelButons;
        private System.Windows.Forms.Button btCadastrarTarefa;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btVoltarTarefa;
        private System.Windows.Forms.Button btExcluirTarefa;
        private System.Windows.Forms.Button btEditarTarefa;
        private System.Windows.Forms.Panel panelTituloBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelRodapeTarefa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPercentual;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvTarefasConcluidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DateTimePicker dtpDataTarefaConclusao;
        private System.Windows.Forms.Label label8;
    }
}