using DapperExtensions;
using Eshopping.PainelAdministrador.Data.Mercadoria.DBModel;
using JsDesenvolvimento.Eshopping.Api.Authentication;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshopping.PainelAdministrador.Logic.Mercadoria.Cqrs
{
    public class FetchProdutoCommand: IRequest<IList<Produto>>
    {
        public FetchProdutoCommand(IPredicate predicate, IUserRef user)
        {
            Predicate = predicate;
            User = user;
        }

        public IPredicate Predicate { get; }
        public IUserRef User { get; }
    }
}
