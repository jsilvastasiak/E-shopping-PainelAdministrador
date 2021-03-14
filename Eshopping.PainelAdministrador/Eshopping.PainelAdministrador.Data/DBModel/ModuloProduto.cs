using DapperExtensions.Mapper;
using Eshopping.PainelAdministrador.Data.Mercadoria.DBModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshopping.PainelAdministrador.Data.DBModel
{
    public static class ModuloProduto
    {
        public class ProdutoMapper: AutoClassMapper<Produto>
        {
            public ProdutoMapper()
            {
                Map(a => a.IdProduto).Column("idproduto").Key(KeyType.Assigned);
                Map(a => a.IdLoja).Column("idloja").Key(KeyType.Assigned);
                Map(a => a.IdPropietario).Column("idpropietario").Key(KeyType.Assigned);
                Map(a => a.IdCategoria).Column("idcategoria").Key(KeyType.Assigned);
                Map(a => a.Nome).Column("nome").Key(KeyType.Assigned);
                Map(a => a.Descricao).Column("descricao").Key(KeyType.Assigned);
                Map(a => a.PrecoUnitario).Column("precounitario").Key(KeyType.Assigned);
                Map(a => a.DataCadastro).Column("datacadastro").Key(KeyType.Assigned);
                Map(a => a.Situacao).Column("situacao").Key(KeyType.Assigned);
                Map(a => a.Marca).Column("marca").Key(KeyType.Assigned);
            }
        }
    }
}
