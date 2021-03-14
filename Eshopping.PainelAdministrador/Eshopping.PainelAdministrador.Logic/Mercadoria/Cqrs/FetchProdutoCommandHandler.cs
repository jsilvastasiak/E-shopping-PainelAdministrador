using Eshopping.PainelAdministrador.Data.Mercadoria;
using Eshopping.PainelAdministrador.Data.Mercadoria.DBModel;
using JsDesenvolvimento.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eshopping.PainelAdministrador.Logic.Mercadoria.Cqrs
{
    public class FetchProdutoCommandHandler : IRequestHandler<FetchProdutoCommand, IList<Produto>>
    {
        private IDbConnectionFactory DbConnectionFactory { get; set; }
        private IDbContextFactory DbContextFactory { get; set; }

        public FetchProdutoCommandHandler(IDbConnectionFactory dbConnectionFactory, IDbContextFactory dbContextFactory)
        {
            DbConnectionFactory = dbConnectionFactory;
            DbContextFactory = dbContextFactory;
        }

        public async Task<IList<Produto>> Handle(FetchProdutoCommand request, CancellationToken cancellationToken)
        {
            using (var ctx = this.DbContextFactory.NewContext())
            {
                var repo = ctx.AcquireRepository<IProdutoRepository>();
                var fetchResult = await repo.Fetch(request.Predicate, cancellationToken).ConfigureAwait(false);

                return fetchResult;
            }
        }
    }
}
