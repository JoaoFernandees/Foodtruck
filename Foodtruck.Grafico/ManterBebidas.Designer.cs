﻿namespace Foodtruck.Grafico
{
    partial class ManterBebidas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbTamanho = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tamanho:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(385, 8);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(10, 20);
            this.tbId.TabIndex = 10;
            this.tbId.Visible = false;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(75, 21);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(304, 20);
            this.tbNome.TabIndex = 11;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(75, 54);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(304, 20);
            this.tbValor.TabIndex = 12;
            this.tbValor.TextChanged += new System.EventHandler(this.tbValor_TextChanged);
            this.tbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_numero);
            // 
            // tbTamanho
            // 
            this.tbTamanho.Location = new System.Drawing.Point(75, 83);
            this.tbTamanho.Name = "tbTamanho";
            this.tbTamanho.Size = new System.Drawing.Size(304, 20);
            this.tbTamanho.TabIndex = 13;
            this.tbTamanho.TextChanged += new System.EventHandler(this.tbTamanho_TextChanged);
            this.tbTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValor_numero);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(223, 125);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 14;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(304, 125);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 15;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ManterBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 163);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbTamanho);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManterBebidas";
            this.Text = "ManterBebidas";
            this.Load += new System.EventHandler(this.ManterBebidas_Load);
            this.Shown += new System.EventHandler(this.ManterBebidas_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbTamanho;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
    }
}