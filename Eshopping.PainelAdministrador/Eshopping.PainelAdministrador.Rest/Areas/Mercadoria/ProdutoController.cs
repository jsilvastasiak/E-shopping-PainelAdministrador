using Eshopping.PainelAdministrador.Data.Mercadoria.DBModel;
using Eshopping.PainelAdministrador.Logic.Mercadoria.Cqrs;
using JsDesenvolvimento.Eshopping.Api.Authentication;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshopping.PainelAdministrador.Rest.Areas.Mercadoria
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public ProdutoController(IMediator mediator, IUserRef userRef)
        {
            Mediator = mediator;
            UserRef = userRef;
        }

        public IMediator Mediator { get; }
        public IUserRef UserRef { get; }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            var cmdFetch = new FetchProdutoCommand(null, this.UserRef);
            var fetchResult = await this.Mediator.Send(cmdFetch);

            return Ok(fetchResult);
        }
    }
}
