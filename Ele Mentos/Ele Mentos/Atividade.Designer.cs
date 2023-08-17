namespace Ele_Mentos
{
    partial class Atividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atividade));
            this.lblnome2 = new System.Windows.Forms.Label();
            this.lblidade = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.bntcadastro2 = new System.Windows.Forms.Button();
            this.lblmostra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnome2
            // 
            this.lblnome2.AutoSize = true;
            this.lblnome2.Location = new System.Drawing.Point(106, 66);
            this.lblnome2.Name = "lblnome2";
            this.lblnome2.Size = new System.Drawing.Size(38, 13);
            this.lblnome2.TabIndex = 0;
            this.lblnome2.Text = "Nome:";
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(106, 92);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(37, 13);
            this.lblidade.TabIndex = 1;
            this.lblidade.Text = "Idade:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(106, 111);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "Email:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(106, 138);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 3;
            this.lblsexo.Text = "Sexo";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(147, 59);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(147, 85);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 5;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(146, 108);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 6;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(147, 135);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 7;
            // 
            // bntcadastro2
            // 
            this.bntcadastro2.Location = new System.Drawing.Point(147, 186);
            this.bntcadastro2.Name = "bntcadastro2";
            this.bntcadastro2.Size = new System.Drawing.Size(75, 23);
            this.bntcadastro2.TabIndex = 8;
            this.bntcadastro2.Text = "Cadastre-se";
            this.bntcadastro2.UseVisualStyleBackColor = true;
            this.bntcadastro2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmostra2
            // 
            this.lblmostra2.AutoSize = true;
            this.lblmostra2.Location = new System.Drawing.Point(109, 272);
            this.lblmostra2.Name = "lblmostra2";
            this.lblmostra2.Size = new System.Drawing.Size(0, 13);
            this.lblmostra2.TabIndex = 9;
            this.lblmostra2.Click += new System.EventHandler(this.lblmostra2_Click);
            // 
            // Atividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmostra2);
            this.Controls.Add(this.bntcadastro2);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblidade);
            this.Controls.Add(this.lblnome2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Atividade";
            this.Text = "Atividade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome2;
        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button bntcadastro2;
        private System.Windows.Forms.Label lblmostra2;
    }
}