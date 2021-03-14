using System;
using System.Collections.Generic;
using System.Text;

namespace Eshopping.PainelAdministrador.Data.Mercadoria.DBModel
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public int IdLoja { get; set; }
        public int IdPropietario { get; set; }
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? PrecoUnitario { get; set; }
        public DateTimeOffset DataCadastro { get; set; }
        public string Situacao { get; set; }
        public string Marca { get; set; }
    }
}
