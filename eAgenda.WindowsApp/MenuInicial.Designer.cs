
namespace eAgenda.WindowsApp
{
    partial class MenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            this.btTarefa = new System.Windows.Forms.Button();
            this.btContato = new System.Windows.Forms.Button();
            this.btCompromisso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSair = new System.Windows.Forms.Button();
            this.panelTituloBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTituloBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btTarefa
            // 
            this.btTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btTarefa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTarefa.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTarefa.ForeColor = System.Drawing.Color.White;
            this.btTarefa.Location = new System.Drawing.Point(3, 86);
            this.btTarefa.Name = "btTarefa";
            this.btTarefa.Size = new System.Drawing.Size(197, 69);
            this.btTarefa.TabIndex = 1;
            this.btTarefa.Text = "Tarefa";
            this.btTarefa.UseVisualStyleBackColor = false;
            this.btTarefa.Click += new System.EventHandler(this.btTarefa_Click);
            // 
            // btContato
            // 
            this.btContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContato.Font = new System.Drawing.Font("Goudy Old Style", 14.25F);
            this.btContato.ForeColor = System.Drawing.Color.White;
            this.btContato.Location = new System.Drawing.Point(206, 86);
            this.btContato.Name = "btContato";
            this.btContato.Size = new System.Drawing.Size(197, 69);
            this.btContato.TabIndex = 2;
            this.btContato.Text = "Contato";
            this.btContato.UseVisualStyleBackColor = false;
            this.btContato.Click += new System.EventHandler(this.btContato_Click);
            // 
            // btCompromisso
            // 
            this.btCompromisso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btCompromisso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCompromisso.Font = new System.Drawing.Font("Goudy Old Style", 14.25F);
            this.btCompromisso.ForeColor = System.Drawing.Color.White;
            this.btCompromisso.Location = new System.Drawing.Point(409, 86);
            this.btCompromisso.Name = "btCompromisso";
            this.btCompromisso.Size = new System.Drawing.Size(197, 69);
            this.btCompromisso.TabIndex = 3;
            this.btCompromisso.Text = "Compromisso";
            this.btCompromisso.UseVisualStyleBackColor = false;
            this.btCompromisso.Click += new System.EventHandler(this.btCompromisso_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btTarefa);
            this.panel1.Controls.Add(this.btCompromisso);
            this.panel1.Controls.Add(this.btContato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 217);
            this.panel1.TabIndex = 31;
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Image = global::eAgenda.WindowsApp.Properties.Resources.Close_16x;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(247, 170);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(115, 36);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "      Sair";
            this.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panelTituloBar
            // 
            this.panelTituloBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(60)))), ((int)(((byte)(189)))));
            this.panelTituloBar.Controls.Add(this.pictureBox1);
            this.panelTituloBar.Controls.Add(this.label7);
            this.panelTituloBar.Controls.Add(this.label1);
            this.panelTituloBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTituloBar.Location = new System.Drawing.Point(0, 0);
            this.panelTituloBar.Name = "panelTituloBar";
            this.panelTituloBar.Size = new System.Drawing.Size(609, 80);
            this.panelTituloBar.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eAgenda.WindowsApp.Properties.Resources.CadastrarIcon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "eAgenda 5.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(609, 217);
            this.Controls.Add(this.panelTituloBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda";
            this.panel1.ResumeLayout(false);
            this.panelTituloBar.ResumeLayout(false);
            this.panelTituloBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btTarefa;
        private System.Windows.Forms.Button btContato;
        private System.Windows.Forms.Button btCompromisso;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTituloBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

