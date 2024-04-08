namespace coletania_de_projetos
{
    partial class frmdesc
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
            this.lblregiao = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lbldesconto = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.txtregiao = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtregiaoFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblregiao
            // 
            this.lblregiao.AutoSize = true;
            this.lblregiao.Location = new System.Drawing.Point(43, 115);
            this.lblregiao.Name = "lblregiao";
            this.lblregiao.Size = new System.Drawing.Size(70, 13);
            this.lblregiao.TabIndex = 0;
            this.lblregiao.Text = "Qual a região";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(43, 57);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(68, 13);
            this.lblpreco.TabIndex = 1;
            this.lblpreco.Text = "Qual o preço";
            // 
            // lbldesconto
            // 
            this.lbldesconto.AutoSize = true;
            this.lbldesconto.Location = new System.Drawing.Point(43, 173);
            this.lbldesconto.Name = "lbldesconto";
            this.lbldesconto.Size = new System.Drawing.Size(53, 13);
            this.lbldesconto.TabIndex = 2;
            this.lbldesconto.Text = "Desconto";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(43, 226);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(61, 13);
            this.lblfinal.TabIndex = 3;
            this.lblfinal.Text = "Preço FInal";
            // 
            // txtregiao
            // 
            this.txtregiao.Location = new System.Drawing.Point(248, 115);
            this.txtregiao.Name = "txtregiao";
            this.txtregiao.Size = new System.Drawing.Size(100, 20);
            this.txtregiao.TabIndex = 4;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(248, 57);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 5;
            // 
            // txtdesconto
            // 
            this.txtdesconto.Enabled = false;
            this.txtdesconto.Location = new System.Drawing.Point(248, 173);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(100, 20);
            this.txtdesconto.TabIndex = 6;
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(248, 226);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(100, 20);
            this.txtfinal.TabIndex = 7;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(46, 311);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtregiaoFinal
            // 
            this.txtregiaoFinal.Location = new System.Drawing.Point(398, 226);
            this.txtregiaoFinal.Name = "txtregiaoFinal";
            this.txtregiaoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtregiaoFinal.TabIndex = 9;
            // 
            // frmdesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtregiaoFinal);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtregiao);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lbldesconto);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblregiao);
            this.Name = "frmdesc";
            this.Text = "desconto por região";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregiao;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lbldesconto;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.TextBox txtregiao;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtregiaoFinal;
    }
}