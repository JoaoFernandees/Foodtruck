﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{
    [Table(name: "Bebidas")]
    public class Bebida : Produto
    {
        public Double Tamanho { get; set; }

        [ForeignKey("Bebidas")]
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override String Descrever()
        {
            return String.Format($"{this.Id} - {this.Nome} - {this.Valor} - {this.Tamanho}ml");
        }
    }
}
