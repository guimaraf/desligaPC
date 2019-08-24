namespace DesligandoPC
{
    partial class FormSobre
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblGithub = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(93, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(291, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Desenvolvido por Frederico Oliveira";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(128, 86);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(223, 20);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contato: guimaraf@gmail.com";
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGithub.Location = new System.Drawing.Point(93, 191);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(313, 20);
            this.lblGithub.TabIndex = 3;
            this.lblGithub.Text = "https://github.com/guimaraf/desligaPC";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownload.Location = new System.Drawing.Point(151, 162);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(181, 20);
            this.lblDownload.TabIndex = 4;
            this.lblDownload.Text = "Download do projeto em";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(151, 22);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(150, 20);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "DesligaPC versão";
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 265);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 304);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 304);
            this.Name = "FormSobre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSobre_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblVersion;
    }
}