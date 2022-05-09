namespace SegundoProjetoTecnico.Telas
{
    partial class TelaEmitirAtestado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEmitirAtestado));
            this.lblAtestadoInfo = new System.Windows.Forms.Label();
            this.txtAtestadoMedico = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoEmitirAtestado = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarEmitirAtestado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvarAtestado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAtestadoInfo
            // 
            this.lblAtestadoInfo.AutoSize = true;
            this.lblAtestadoInfo.Location = new System.Drawing.Point(12, 43);
            this.lblAtestadoInfo.Name = "lblAtestadoInfo";
            this.lblAtestadoInfo.Size = new System.Drawing.Size(87, 13);
            this.lblAtestadoInfo.TabIndex = 0;
            this.lblAtestadoInfo.Text = "Atestado Médico";
            // 
            // txtAtestadoMedico
            // 
            this.txtAtestadoMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtestadoMedico.Location = new System.Drawing.Point(12, 59);
            this.txtAtestadoMedico.Multiline = true;
            this.txtAtestadoMedico.Name = "txtAtestadoMedico";
            this.txtAtestadoMedico.Size = new System.Drawing.Size(390, 374);
            this.txtAtestadoMedico.TabIndex = 1;
            this.txtAtestadoMedico.Text = resources.GetString("txtAtestadoMedico.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoEmitirAtestado});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoEmitirAtestado
            // 
            this.arquivoEmitirAtestado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarEmitirAtestado});
            this.arquivoEmitirAtestado.Name = "arquivoEmitirAtestado";
            this.arquivoEmitirAtestado.Size = new System.Drawing.Size(61, 20);
            this.arquivoEmitirAtestado.Text = "Arquivo";
            // 
            // salvarEmitirAtestado
            // 
            this.salvarEmitirAtestado.Name = "salvarEmitirAtestado";
            this.salvarEmitirAtestado.Size = new System.Drawing.Size(105, 22);
            this.salvarEmitirAtestado.Text = "Salvar";
            this.salvarEmitirAtestado.Click += new System.EventHandler(this.salvarEmitirAtestado_Click);
            // 
            // btnSalvarAtestado
            // 
            this.btnSalvarAtestado.Location = new System.Drawing.Point(327, 439);
            this.btnSalvarAtestado.Name = "btnSalvarAtestado";
            this.btnSalvarAtestado.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAtestado.TabIndex = 3;
            this.btnSalvarAtestado.Text = "Salvar";
            this.btnSalvarAtestado.UseVisualStyleBackColor = true;
            this.btnSalvarAtestado.Click += new System.EventHandler(this.btnSalvarAtestado_Click);
            // 
            // TelaEmitirAtestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 471);
            this.Controls.Add(this.btnSalvarAtestado);
            this.Controls.Add(this.txtAtestadoMedico);
            this.Controls.Add(this.lblAtestadoInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaEmitirAtestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEmitirAtestado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAtestadoInfo;
        public System.Windows.Forms.TextBox txtAtestadoMedico;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem arquivoEmitirAtestado;
        public System.Windows.Forms.ToolStripMenuItem salvarEmitirAtestado;
        public System.Windows.Forms.Button btnSalvarAtestado;
    }
}