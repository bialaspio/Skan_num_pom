namespace Bierun_numerowanie_operatow
{
    partial class FormLogin
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
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNazUzytkownika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btLogowanie = new System.Windows.Forms.Button();
            this.btZamknij = new System.Windows.Forms.Button();
            this.dgvLogowanie = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogowanie)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHaslo
            // 
            this.txtHaslo.Enabled = false;
            this.txtHaslo.Location = new System.Drawing.Point(139, 45);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.PasswordChar = '*';
            this.txtHaslo.Size = new System.Drawing.Size(217, 20);
            this.txtHaslo.TabIndex = 2;
            this.txtHaslo.Text = "pbialas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNazUzytkownika);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHaslo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 76);
            this.panel1.TabIndex = 8;
            // 
            // txtNazUzytkownika
            // 
            this.txtNazUzytkownika.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNazUzytkownika.Location = new System.Drawing.Point(140, 12);
            this.txtNazUzytkownika.Name = "txtNazUzytkownika";
            this.txtNazUzytkownika.Size = new System.Drawing.Size(216, 20);
            this.txtNazUzytkownika.TabIndex = 1;
            this.txtNazUzytkownika.Text = "pbialas";
            this.txtNazUzytkownika.TextChanged += new System.EventHandler(this.txtNazUzytkownika_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nazwa użytkownika :";
            // 
            // btLogowanie
            // 
            this.btLogowanie.Location = new System.Drawing.Point(317, 94);
            this.btLogowanie.Name = "btLogowanie";
            this.btLogowanie.Size = new System.Drawing.Size(75, 23);
            this.btLogowanie.TabIndex = 3;
            this.btLogowanie.Text = "Zaloguj";
            this.btLogowanie.UseVisualStyleBackColor = true;
            this.btLogowanie.Click += new System.EventHandler(this.btLogowanie_Click);
            // 
            // btZamknij
            // 
            this.btZamknij.Location = new System.Drawing.Point(220, 94);
            this.btZamknij.Name = "btZamknij";
            this.btZamknij.Size = new System.Drawing.Size(75, 23);
            this.btZamknij.TabIndex = 4;
            this.btZamknij.Text = "Zamknij";
            this.btZamknij.UseVisualStyleBackColor = true;
            this.btZamknij.Click += new System.EventHandler(this.btZamknij_Click);
            // 
            // dgvLogowanie
            // 
            this.dgvLogowanie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogowanie.Location = new System.Drawing.Point(12, 88);
            this.dgvLogowanie.Name = "dgvLogowanie";
            this.dgvLogowanie.Size = new System.Drawing.Size(29, 29);
            this.dgvLogowanie.TabIndex = 5;
            this.dgvLogowanie.TabStop = false;
            this.dgvLogowanie.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 131);
            this.Controls.Add(this.dgvLogowanie);
            this.Controls.Add(this.btZamknij);
            this.Controls.Add(this.btLogowanie);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(424, 170);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogowanie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHaslo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLogowanie;
        private System.Windows.Forms.Button btZamknij;
        private System.Windows.Forms.TextBox txtNazUzytkownika;
        private System.Windows.Forms.DataGridView dgvLogowanie;
    }
}