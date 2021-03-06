using Autofac;
using JsDesenvolvimento.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eshopping.PainelAdministrador.Data
{
    public class DIModule : Autofac.Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(this.ThisAssembly)
                .AsClosedTypesOf(typeof(IDefaultRepository<>))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
