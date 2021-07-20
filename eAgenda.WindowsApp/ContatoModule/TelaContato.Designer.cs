
namespace eAgenda.WindowsApp
{
    partial class TelaContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaContato));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtbTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.tbIdContato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmpresaContato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCargoContato = new System.Windows.Forms.TextBox();
            this.tbEmailContato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeContato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dtContato = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVoltarContato = new System.Windows.Forms.Button();
            this.btExcluirContato = new System.Windows.Forms.Button();
            this.btEditarComtato = new System.Windows.Forms.Button();
            this.btEditarContato = new System.Windows.Forms.Button();
            this.btCadastrarContato = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelTituloBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelRodapeContato = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContato)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTituloBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contato";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.mtbTelefoneContato);
            this.groupBox3.Controls.Add(this.tbIdContato);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbEmpresaContato);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbCargoContato);
            this.groupBox3.Controls.Add(this.tbEmailContato);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbNomeContato);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(155, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(658, 106);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // mtbTelefoneContato
            // 
            this.mtbTelefoneContato.Location = new System.Drawing.Point(450, 15);
            this.mtbTelefoneContato.Mask = "(00)00000-9999";
            this.mtbTelefoneContato.Name = "mtbTelefoneContato";
            this.mtbTelefoneContato.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefoneContato.TabIndex = 23;
            // 
            // tbIdContato
            // 
            this.tbIdContato.Location = new System.Drawing.Point(111, 12);
            this.tbIdContato.Name = "tbIdContato";
            this.tbIdContato.Size = new System.Drawing.Size(148, 20);
            this.tbIdContato.TabIndex = 22;
            this.tbIdContato.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbIdContato_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Id:";
            // 
            // tbEmpresaContato
            // 
            this.tbEmpresaContato.Location = new System.Drawing.Point(450, 74);
            this.tbEmpresaContato.Name = "tbEmpresaContato";
            this.tbEmpresaContato.Size = new System.Drawing.Size(148, 20);
            this.tbEmpresaContato.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Empresa:";
            // 
            // tbCargoContato
            // 
            this.tbCargoContato.Location = new System.Drawing.Point(450, 42);
            this.tbCargoContato.Name = "tbCargoContato";
            this.tbCargoContato.Size = new System.Drawing.Size(148, 20);
            this.tbCargoContato.TabIndex = 18;
            // 
            // tbEmailContato
            // 
            this.tbEmailContato.Location = new System.Drawing.Point(112, 64);
            this.tbEmailContato.Name = "tbEmailContato";
            this.tbEmailContato.Size = new System.Drawing.Size(148, 20);
            this.tbEmailContato.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // tbNomeContato
            // 
            this.tbNomeContato.Location = new System.Drawing.Point(112, 38);
            this.tbNomeContato.Name = "tbNomeContato";
            this.tbNomeContato.Size = new System.Drawing.Size(148, 20);
            this.tbNomeContato.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cargo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(155, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 198);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contatos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "dtContato";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dtContato});
            // 
            // dtContato
            // 
            this.dtContato.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtContato.TableName = "dtContato";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Nome";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Email";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Telefone";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Cargo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Empresa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btVoltarContato);
            this.panel1.Controls.Add(this.btExcluirContato);
            this.panel1.Controls.Add(this.btEditarComtato);
            this.panel1.Controls.Add(this.btEditarContato);
            this.panel1.Controls.Add(this.btCadastrarContato);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 421);
            this.panel1.TabIndex = 26;
            // 
            // btVoltarContato
            // 
            this.btVoltarContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltarContato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVoltarContato.FlatAppearance.BorderSize = 0;
            this.btVoltarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarContato.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btVoltarContato.ForeColor = System.Drawing.Color.White;
            this.btVoltarContato.Location = new System.Drawing.Point(0, 320);
            this.btVoltarContato.Name = "btVoltarContato";
            this.btVoltarContato.Size = new System.Drawing.Size(149, 101);
            this.btVoltarContato.TabIndex = 24;
            this.btVoltarContato.Text = "Menu Inicial";
            this.btVoltarContato.UseVisualStyleBackColor = true;
            this.btVoltarContato.Click += new System.EventHandler(this.btVoltarContato_Click_1);
            // 
            // btExcluirContato
            // 
            this.btExcluirContato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btExcluirContato.FlatAppearance.BorderSize = 0;
            this.btExcluirContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirContato.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btExcluirContato.ForeColor = System.Drawing.Color.White;
            this.btExcluirContato.Location = new System.Drawing.Point(0, 240);
            this.btExcluirContato.Name = "btExcluirContato";
            this.btExcluirContato.Size = new System.Drawing.Size(149, 80);
            this.btExcluirContato.TabIndex = 23;
            this.btExcluirContato.Text = "Excluir";
            this.btExcluirContato.UseVisualStyleBackColor = true;
            this.btExcluirContato.Click += new System.EventHandler(this.btExcluirContato_Click_1);
            // 
            // btEditarComtato
            // 
            this.btEditarComtato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEditarComtato.FlatAppearance.BorderSize = 0;
            this.btEditarComtato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarComtato.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btEditarComtato.ForeColor = System.Drawing.Color.White;
            this.btEditarComtato.Location = new System.Drawing.Point(0, 160);
            this.btEditarComtato.Name = "btEditarComtato";
            this.btEditarComtato.Size = new System.Drawing.Size(149, 80);
            this.btEditarComtato.TabIndex = 22;
            this.btEditarComtato.Text = "Editar";
            this.btEditarComtato.UseVisualStyleBackColor = true;
            this.btEditarComtato.Click += new System.EventHandler(this.btEditarComtato_Click);
            // 
            // btEditarContato
            // 
            this.btEditarContato.Location = new System.Drawing.Point(37, 183);
            this.btEditarContato.Name = "btEditarContato";
            this.btEditarContato.Size = new System.Drawing.Size(0, 0);
            this.btEditarContato.TabIndex = 21;
            this.btEditarContato.Text = "Editar";
            this.btEditarContato.UseVisualStyleBackColor = true;
            // 
            // btCadastrarContato
            // 
            this.btCadastrarContato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastrarContato.FlatAppearance.BorderSize = 0;
            this.btCadastrarContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarContato.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btCadastrarContato.ForeColor = System.Drawing.Color.White;
            this.btCadastrarContato.Location = new System.Drawing.Point(0, 80);
            this.btCadastrarContato.Name = "btCadastrarContato";
            this.btCadastrarContato.Size = new System.Drawing.Size(149, 80);
            this.btCadastrarContato.TabIndex = 19;
            this.btCadastrarContato.Text = "Cadastrar";
            this.btCadastrarContato.UseVisualStyleBackColor = true;
            this.btCadastrarContato.Click += new System.EventHandler(this.btCadastrarContato_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 80);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eAgenda.WindowsApp.Properties.Resources.CadastrarIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(42, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "e-Agenda";
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
            this.panelTituloBar.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eAgenda.WindowsApp.Properties.Resources.contact;
            this.pictureBox2.Location = new System.Drawing.Point(247, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelRodapeContato});
            this.statusStrip1.Location = new System.Drawing.Point(149, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelRodapeContato
            // 
            this.labelRodapeContato.ForeColor = System.Drawing.Color.White;
            this.labelRodapeContato.Name = "labelRodapeContato";
            this.labelRodapeContato.Size = new System.Drawing.Size(82, 17);
            this.labelRodapeContato.Text = "Aguardando...";
            // 
            // TelaContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelTituloBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContato)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTituloBar.ResumeLayout(false);
            this.panelTituloBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbEmailContato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeContato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmpresaContato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCargoContato;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dtContato;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbIdContato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelTituloBar;
        private System.Windows.Forms.Button btCadastrarContato;
        private System.Windows.Forms.Button btEditarComtato;
        private System.Windows.Forms.Button btEditarContato;
        private System.Windows.Forms.Button btVoltarContato;
        private System.Windows.Forms.Button btExcluirContato;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelRodapeContato;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneContato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}