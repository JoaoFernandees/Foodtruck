﻿using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class ManterLanches : Form
    {
        public Lanche LancheSelecionado { get; set; }

        public ManterLanches()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterLanches_Shown(object sender, EventArgs e)
        {
            if (LancheSelecionado != null)
            {
                this.tbId.Text = LancheSelecionado.Id.ToString();
                this.tbNome.Text = LancheSelecionado.Nome;
                this.tbValor.Text = LancheSelecionado.Valor.ToString();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Lanche lanche = new Lanche();
            if (Int64.TryParse(tbId.Text, out long value))
            {
                lanche.Id = value;
            }
            else
            {
                lanche.Id = -1;
            }
            lanche.Nome = tbNome.Text;

            if (Decimal.TryParse(tbValor.Text, out decimal result))
            {
                lanche.Valor = result;
            }

            else
            {
                lanche.Valor = -1;

            }

            Validacao validacao;
            if (LancheSelecionado == null)
            {
                validacao = Program.Gerenciador.CadastraLanche(lanche);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarLanche(lanche);
            }

            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Lanche salvo com sucesso");
            }

            this.Close();
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }
        //validação numero

        private void tbValor_numero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Decimal && e.KeyChar != (char)Keys.Oemcomma && e.KeyChar != (char)Keys.OemPeriod)
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero");
            }
        }
    }
}
