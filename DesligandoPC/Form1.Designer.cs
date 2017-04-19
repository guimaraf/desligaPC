namespace DesligandoPC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cBoxSeconds = new System.Windows.Forms.CheckBox();
            this.cBoxMinuts = new System.Windows.Forms.CheckBox();
            this.cBoxHours = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarDesligamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(146, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 81);
            this.button1.TabIndex = 1;
            this.button1.Text = "Desligar PC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(133, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo para desligar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(146, 161);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cBoxSeconds
            // 
            this.cBoxSeconds.AutoSize = true;
            this.cBoxSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSeconds.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cBoxSeconds.Location = new System.Drawing.Point(303, 74);
            this.cBoxSeconds.Name = "cBoxSeconds";
            this.cBoxSeconds.Size = new System.Drawing.Size(109, 24);
            this.cBoxSeconds.TabIndex = 4;
            this.cBoxSeconds.Text = "Segundos";
            this.cBoxSeconds.UseVisualStyleBackColor = true;
            this.cBoxSeconds.Click += new System.EventHandler(this.cBoxSeconds_Click);
            // 
            // cBoxMinuts
            // 
            this.cBoxMinuts.AutoSize = true;
            this.cBoxMinuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMinuts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cBoxMinuts.Location = new System.Drawing.Point(174, 74);
            this.cBoxMinuts.Name = "cBoxMinuts";
            this.cBoxMinuts.Size = new System.Drawing.Size(91, 24);
            this.cBoxMinuts.TabIndex = 3;
            this.cBoxMinuts.Text = "Minutos";
            this.cBoxMinuts.UseVisualStyleBackColor = true;
            this.cBoxMinuts.Click += new System.EventHandler(this.cBoxMinuts_Click);
            // 
            // cBoxHours
            // 
            this.cBoxHours.AutoSize = true;
            this.cBoxHours.Checked = true;
            this.cBoxHours.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxHours.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cBoxHours.Location = new System.Drawing.Point(45, 74);
            this.cBoxHours.Name = "cBoxHours";
            this.cBoxHours.Size = new System.Drawing.Size(76, 24);
            this.cBoxHours.TabIndex = 2;
            this.cBoxHours.Text = "Horas";
            this.cBoxHours.UseVisualStyleBackColor = true;
            this.cBoxHours.Click += new System.EventHandler(this.cBoxHours_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.açãoToolStripMenuItem,
            this.idiomaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // açãoToolStripMenuItem
            // 
            this.açãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelarDesligamentoToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.hibernarToolStripMenuItem});
            this.açãoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.açãoToolStripMenuItem.Name = "açãoToolStripMenuItem";
            this.açãoToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.açãoToolStripMenuItem.Text = "Ação";
            // 
            // cancelarDesligamentoToolStripMenuItem
            // 
            this.cancelarDesligamentoToolStripMenuItem.Name = "cancelarDesligamentoToolStripMenuItem";
            this.cancelarDesligamentoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cancelarDesligamentoToolStripMenuItem.Text = "Cancelar desligamento";
            this.cancelarDesligamentoToolStripMenuItem.Click += new System.EventHandler(this.cancelarDesligamentoToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portugêsToolStripMenuItem,
            this.inglêsToolStripMenuItem});
            this.idiomaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // portugêsToolStripMenuItem
            // 
            this.portugêsToolStripMenuItem.Checked = true;
            this.portugêsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.portugêsToolStripMenuItem.Name = "portugêsToolStripMenuItem";
            this.portugêsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.portugêsToolStripMenuItem.Text = "Português";
            this.portugêsToolStripMenuItem.Click += new System.EventHandler(this.portugêsToolStripMenuItem_Click);
            // 
            // inglêsToolStripMenuItem
            // 
            this.inglêsToolStripMenuItem.Name = "inglêsToolStripMenuItem";
            this.inglêsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inglêsToolStripMenuItem.Text = "Inglês";
            this.inglêsToolStripMenuItem.Click += new System.EventHandler(this.inglêsToolStripMenuItem_Click);
            // 
            // hibernarToolStripMenuItem
            // 
            this.hibernarToolStripMenuItem.Name = "hibernarToolStripMenuItem";
            this.hibernarToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.hibernarToolStripMenuItem.Text = "Hibernar";
            this.hibernarToolStripMenuItem.Click += new System.EventHandler(this.hibernarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(446, 323);
            this.Controls.Add(this.cBoxHours);
            this.Controls.Add(this.cBoxMinuts);
            this.Controls.Add(this.cBoxSeconds);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(462, 362);
            this.MinimumSize = new System.Drawing.Size(462, 362);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desligando o PC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cBoxSeconds;
        private System.Windows.Forms.CheckBox cBoxMinuts;
        private System.Windows.Forms.CheckBox cBoxHours;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarDesligamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hibernarToolStripMenuItem;
    }
}

