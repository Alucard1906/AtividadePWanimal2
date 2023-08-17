namespace Ele_Mentos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btcadastra = new System.Windows.Forms.Button();
            this.lblmostra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(46, 81);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(42, 14);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            this.lblnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 8.25F);
            this.txtnome.Location = new System.Drawing.Point(94, 81);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(202, 20);
            this.txtnome.TabIndex = 1;
            // 
            // btcadastra
            // 
            this.btcadastra.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastra.Location = new System.Drawing.Point(94, 107);
            this.btcadastra.Name = "btcadastra";
            this.btcadastra.Size = new System.Drawing.Size(118, 37);
            this.btcadastra.TabIndex = 2;
            this.btcadastra.Text = "Cadastre-se";
            this.btcadastra.UseVisualStyleBackColor = true;
            this.btcadastra.Click += new System.EventHandler(this.btcadastra_Click);
            // 
            // lblmostra
            // 
            this.lblmostra.AutoSize = true;
            this.lblmostra.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmostra.Location = new System.Drawing.Point(49, 186);
            this.lblmostra.Name = "lblmostra";
            this.lblmostra.Size = new System.Drawing.Size(0, 14);
            this.lblmostra.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 271);
            this.Controls.Add(this.lblmostra);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btcadastra);
            this.Controls.Add(this.txtnome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro de Nomes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btcadastra;
        private System.Windows.Forms.Label lblmostra;
    }
}

