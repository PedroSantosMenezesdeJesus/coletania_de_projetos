namespace coletania_de_projetos
{
    partial class frmcidadania
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
            this.lblcidania = new System.Windows.Forms.Label();
            this.txtcidadania = new System.Windows.Forms.TextBox();
            this.txtMostrarCidadania = new System.Windows.Forms.TextBox();
            this.lblMostrarCidadania = new System.Windows.Forms.Label();
            this.lbllingua = new System.Windows.Forms.Label();
            this.txtlingua = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcidania
            // 
            this.lblcidania.AutoSize = true;
            this.lblcidania.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcidania.Location = new System.Drawing.Point(24, 45);
            this.lblcidania.Name = "lblcidania";
            this.lblcidania.Size = new System.Drawing.Size(346, 25);
            this.lblcidania.TabIndex = 0;
            this.lblcidania.Text = "coloque o código da sua cidadania";
            // 
            // txtcidadania
            // 
            this.txtcidadania.Location = new System.Drawing.Point(418, 49);
            this.txtcidadania.Name = "txtcidadania";
            this.txtcidadania.Size = new System.Drawing.Size(100, 20);
            this.txtcidadania.TabIndex = 1;
            this.txtcidadania.TextChanged += new System.EventHandler(this.txtcidadania_TextChanged);
            // 
            // txtMostrarCidadania
            // 
            this.txtMostrarCidadania.Enabled = false;
            this.txtMostrarCidadania.Location = new System.Drawing.Point(156, 115);
            this.txtMostrarCidadania.Name = "txtMostrarCidadania";
            this.txtMostrarCidadania.Size = new System.Drawing.Size(100, 20);
            this.txtMostrarCidadania.TabIndex = 2;
            // 
            // lblMostrarCidadania
            // 
            this.lblMostrarCidadania.AutoSize = true;
            this.lblMostrarCidadania.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarCidadania.Location = new System.Drawing.Point(24, 109);
            this.lblMostrarCidadania.Name = "lblMostrarCidadania";
            this.lblMostrarCidadania.Size = new System.Drawing.Size(85, 25);
            this.lblMostrarCidadania.TabIndex = 3;
            this.lblMostrarCidadania.Text = "Você é:";
            // 
            // lbllingua
            // 
            this.lbllingua.AutoSize = true;
            this.lbllingua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllingua.Location = new System.Drawing.Point(24, 183);
            this.lbllingua.Name = "lbllingua";
            this.lbllingua.Size = new System.Drawing.Size(138, 25);
            this.lbllingua.TabIndex = 4;
            this.lbllingua.Text = "Sua lingua é:";
            // 
            // txtlingua
            // 
            this.txtlingua.Enabled = false;
            this.txtlingua.Location = new System.Drawing.Point(185, 187);
            this.txtlingua.Name = "txtlingua";
            this.txtlingua.Size = new System.Drawing.Size(100, 20);
            this.txtlingua.TabIndex = 6;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(352, 266);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 7;
            this.btnmostrar.Text = "MOSTRAR";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(352, 333);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmcidadania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtlingua);
            this.Controls.Add(this.lbllingua);
            this.Controls.Add(this.lblMostrarCidadania);
            this.Controls.Add(this.txtMostrarCidadania);
            this.Controls.Add(this.txtcidadania);
            this.Controls.Add(this.lblcidania);
            this.Name = "frmcidadania";
            this.Text = "frmcidadania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcidania;
        private System.Windows.Forms.TextBox txtcidadania;
        private System.Windows.Forms.TextBox txtMostrarCidadania;
        private System.Windows.Forms.Label lblMostrarCidadania;
        private System.Windows.Forms.Label lbllingua;
        private System.Windows.Forms.TextBox txtlingua;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnvoltar;
    }
}