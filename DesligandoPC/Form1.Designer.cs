using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cBoxMinuts = new System.Windows.Forms.CheckBox();
            this.cBoxHours = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboultMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibernateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugueseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cBoxHibernar = new System.Windows.Forms.CheckBox();
            this.cBoxSeconds = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(174, 303);
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
            this.label1.Location = new System.Drawing.Point(161, 175);
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
            this.textBox1.Location = new System.Drawing.Point(163, 226);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 49);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cBoxMinuts
            // 
            this.cBoxMinuts.AutoSize = true;
            this.cBoxMinuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxMinuts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cBoxMinuts.Location = new System.Drawing.Point(200, 122);
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
            this.cBoxHours.Location = new System.Drawing.Point(71, 122);
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
            this.fileMenuItem,
            this.actionMenuItem,
            this.languageMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboultMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fileMenuItem.Text = "Arquivo";
            // 
            // aboultMenuItem
            // 
            this.aboultMenuItem.Name = "aboultMenuItem";
            this.aboultMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboultMenuItem.Text = "Sobre";
            this.aboultMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Sair";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // actionMenuItem
            // 
            this.actionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rebootMenuItem,
            this.hibernateMenuItem,
            this.shutdownMenuItem});
            this.actionMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionMenuItem.Name = "actionMenuItem";
            this.actionMenuItem.Size = new System.Drawing.Size(52, 20);
            this.actionMenuItem.Text = "Ação";
            // 
            // rebootMenuItem
            // 
            this.rebootMenuItem.Name = "rebootMenuItem";
            this.rebootMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rebootMenuItem.Text = "Reiniciar Agora";
            this.rebootMenuItem.Click += new System.EventHandler(this.RebootMenuItem_Click);
            // 
            // hibernateMenuItem
            // 
            this.hibernateMenuItem.Name = "hibernateMenuItem";
            this.hibernateMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hibernateMenuItem.Text = "Hibernar Agora";
            this.hibernateMenuItem.Click += new System.EventHandler(this.HibernateMenuItem_Click);
            // 
            // shutdownMenuItem
            // 
            this.shutdownMenuItem.Name = "shutdownMenuItem";
            this.shutdownMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shutdownMenuItem.Text = "Desligar Agora";
            this.shutdownMenuItem.Click += new System.EventHandler(this.ShutdownMenuItem_Click);
            // 
            // languageMenuItem
            // 
            this.languageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portugueseMenuItem,
            this.englishMenuItem});
            this.languageMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageMenuItem.Name = "languageMenuItem";
            this.languageMenuItem.Size = new System.Drawing.Size(61, 20);
            this.languageMenuItem.Text = "Idioma";
            // 
            // portugueseMenuItem
            // 
            this.portugueseMenuItem.Checked = true;
            this.portugueseMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.portugueseMenuItem.Name = "portugueseMenuItem";
            this.portugueseMenuItem.Size = new System.Drawing.Size(180, 22);
            this.portugueseMenuItem.Text = "Português";
            this.portugueseMenuItem.Click += new System.EventHandler(this.PortugueseMenuItem_Click);
            // 
            // englishMenuItem
            // 
            this.englishMenuItem.Name = "englishMenuItem";
            this.englishMenuItem.Size = new System.Drawing.Size(180, 22);
            this.englishMenuItem.Text = "Inglês";
            this.englishMenuItem.Click += new System.EventHandler(this.EnglishMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cBoxHibernar
            // 
            this.cBoxHibernar.AutoSize = true;
            this.cBoxHibernar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxHibernar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cBoxHibernar.Location = new System.Drawing.Point(200, 77);
            this.cBoxHibernar.Name = "cBoxHibernar";
            this.cBoxHibernar.Size = new System.Drawing.Size(97, 24);
            this.cBoxHibernar.TabIndex = 7;
            this.cBoxHibernar.Text = "Hibernar";
            this.cBoxHibernar.UseVisualStyleBackColor = true;
            this.cBoxHibernar.CheckedChanged += new System.EventHandler(this.cBoxHibernar_CheckedChanged);
            // 
            // cBoxSeconds
            // 
            this.cBoxSeconds.AutoSize = true;
            this.cBoxSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxSeconds.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cBoxSeconds.Location = new System.Drawing.Point(329, 122);
            this.cBoxSeconds.Name = "cBoxSeconds";
            this.cBoxSeconds.Size = new System.Drawing.Size(109, 24);
            this.cBoxSeconds.TabIndex = 4;
            this.cBoxSeconds.Text = "Segundos";
            this.cBoxSeconds.UseVisualStyleBackColor = true;
            this.cBoxSeconds.Click += new System.EventHandler(this.cBoxSeconds_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(496, 429);
            this.Controls.Add(this.cBoxHibernar);
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
            this.MaximumSize = new System.Drawing.Size(512, 468);
            this.MinimumSize = new System.Drawing.Size(512, 468);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desligando o PC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cBoxMinuts;
        private System.Windows.Forms.CheckBox cBoxHours;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboultMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugueseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hibernateMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem shutdownMenuItem;
        private System.Windows.Forms.CheckBox cBoxHibernar;
        private System.Windows.Forms.CheckBox cBoxSeconds;

        public Button Button1 { get => button1; set => button1 = value; }
    }
}

