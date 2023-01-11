using Adaptador.Interfaces;
using Adapter.Map;
using Adapter.Utils;
using Application.Interface;
using Application.Service;
using Autofac;
using Core.Interface.Repositorio;
using Core.Interface.Servicos;
using Repositorio.Repositorios;
using Servico.Servicos;

namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC SERVICE
            builder.RegisterType<ServiceUsuarios>().As<IServiceUsuarios>();

            #endregion

            #region IOC REPOSITORY
            builder.RegisterType<RepositoryUsuarios>().As<IRepositoryUsuarios>();
            #endregion

            #region IOC MAPPER
            builder.RegisterType<MapperLogin>().As<IMapperLogin>();
            #endregion

            #region IOC APPLICATION
            builder.RegisterType<ApplicationLogin>().As<IApplicationLogin>();
            #endregion

            #region IOC VALIDATOR
            #endregion

            #region IOC Utils
            builder.RegisterType<GeraToken>().As<IGeraToken>();
            #endregion
        }
    }
}
