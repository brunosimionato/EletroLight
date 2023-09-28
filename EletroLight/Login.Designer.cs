namespace EletroLight
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.entrarBT = new System.Windows.Forms.Button();
            this.usuarioTB = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.senhaTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // entrarBT
            // 
            this.entrarBT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.entrarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarBT.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.entrarBT.ForeColor = System.Drawing.Color.White;
            this.entrarBT.Location = new System.Drawing.Point(60, 185);
            this.entrarBT.Name = "entrarBT";
            this.entrarBT.Size = new System.Drawing.Size(216, 46);
            this.entrarBT.TabIndex = 68;
            this.entrarBT.Text = "Entrar";
            this.entrarBT.UseVisualStyleBackColor = false;
            this.entrarBT.Click += new System.EventHandler(this.entrarBT_Click);
            // 
            // usuarioTB
            // 
            this.usuarioTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usuarioTB.Location = new System.Drawing.Point(60, 58);
            this.usuarioTB.MaxLength = 50;
            this.usuarioTB.Name = "usuarioTB";
            this.usuarioTB.Size = new System.Drawing.Size(216, 29);
            this.usuarioTB.TabIndex = 70;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usuarioLabel.Location = new System.Drawing.Point(56, 34);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(64, 21);
            this.usuarioLabel.TabIndex = 69;
            this.usuarioLabel.Text = "Usuário";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.senhaLabel.Location = new System.Drawing.Point(56, 102);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(56, 21);
            this.senhaLabel.TabIndex = 72;
            this.senhaLabel.Text = "Senha:";
            // 
            // senhaTB
            // 
            this.senhaTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.senhaTB.Location = new System.Drawing.Point(60, 126);
            this.senhaTB.MaxLength = 10;
            this.senhaTB.Name = "senhaTB";
            this.senhaTB.PasswordChar = '*';
            this.senhaTB.Size = new System.Drawing.Size(216, 29);
            this.senhaTB.TabIndex = 71;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(338, 278);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.senhaTB);
            this.Controls.Add(this.usuarioTB);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.entrarBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrarBT;
        private System.Windows.Forms.TextBox usuarioTB;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox senhaTB;
    }
}