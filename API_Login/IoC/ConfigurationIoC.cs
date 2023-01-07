using Adaptador.Interfaces;
using Adapter.Map;
using Adapter.Utils;
using Application.Interface;
using Application.Service;
using Autofac;
using Core.Interface.Repositorio;
using Core.Interface.Servicos;
using Repositorio.Repositorios;
using Repository.Repositorios;
using Service.Servicos;
using Servico.Servicos;

namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC SERVICE
            builder.RegisterType<ServiceUsuarios>().As<IServiceUsuarios>();
            //builder.RegisterType<ServiceGrupos>().As<IServiceGrupos>();
            builder.RegisterType<ServiceAuthAcesso>().As<IServiceAuthAcesso>();
            //builder.RegisterType<ServiceAuthGrupoXAcesso>().As<IServiceAuthGrupoXAcesso>();

            #endregion

            #region IOC REPOSITORY
            builder.RegisterType<RepositoryUsuarios>().As<IRepositoryUsuarios>();
            //builder.RegisterType<RepositoryGrupos>().As<IRepositoryGrupos>();
            builder.RegisterType<RepositoryAuthAcesso>().As<IRepositoryAuthAcesso>();
            //builder.RegisterType<RepositoryAuthGrupoXAcesso>().As<IRepositoryAuthGrupoXAcesso>();
            #endregion

            #region IOC MAPPER
            //builder.RegisterType<MapperGetUsuarios>().As<IMapperGetUsuarios>();
            //builder.RegisterType<MapperUpdateUsuarios>().As<IMapperUpdateUsuarios>();
            //builder.RegisterType<MapperAddUsuarios>().As<IMapperAddUsuarios>();
            //builder.RegisterType<MapperGetGrupos>().As<IMapperGetGrupos>();
            //builder.RegisterType<MapperUpdateGrupos>().As<IMapperUpdateGrupos>();
            //builder.RegisterType<MapperAddGrupos>().As<IMapperAddGrupos>();
            //builder.RegisterType<MapperAddAuthAcesso>().As<IMapperAddAuthAcesso>();
            //builder.RegisterType<MapperGetAuthAcesso>().As<IMapperGetAuthAcesso>();
            //builder.RegisterType<MapperUpdateAuthAcesso>().As<IMapperUpdateAuthAcesso>();
            //builder.RegisterType<MapperAddAuthGrupoXAcessoDTO>().As<IMapperAddAuthGrupoXAcessoDTO>();
            //builder.RegisterType<MapperDelAuthGrupoXAcessoDTO>().As<IMapperDelAuthGrupoXAcessoDTO>();
            //builder.RegisterType<MapperGetAuthGrupoXAcesso>().As<IMapperGetAuthGrupoXAcesso>();
            builder.RegisterType<MapperLogin>().As<IMapperLogin>();
            #endregion

            #region IOC APPLICATION
            //builder.RegisterType<ApplicationUsuarios>().As<IApplicationUsuarios>();
            //builder.RegisterType<ApplicationGrupos>().As<IApplicationGrupos>();
            //builder.RegisterType<ApplicationAuthAcesso>().As<IApplicationAuthAcesso>();
            //builder.RegisterType<ApplicationAuthGrupoXAcesso>().As<IApplicationAuthGrupoXAcesso>();
            builder.RegisterType<ApplicationLogin>().As<IApplicationLogin>();
            #endregion

            #region IOC VALIDATOR
            //builder.RegisterType<ValidacaoAddUsuarios>().As<IValidacaoAddUsuarios>();
            //builder.RegisterType<ValidacaoUpdateUsuarios>().As<IValidacaoUpdateUsuarios>();
            //builder.RegisterType<ValidacaoUpdateGrupos>().As<IValidacaoUpdateGrupos>();
            //builder.RegisterType<ValidacaoAddGrupos>().As<IValidacaoAddGrupos>();
            //builder.RegisterType<ValidacaoAddAuthAcesso>().As<IValidacaoAddAuthAcesso>();
            //builder.RegisterType<ValidacaoUpdateAuthAcesso>().As<IValidacaoUpdateAuthAcesso>();
            //builder.RegisterType<ValidacaoAddAuthGrupoXAcesso>().As<IValidacaoAddAuthGrupoXAcesso>();
            //builder.RegisterType<ValidacaoDelAuthGrupoXAcesso>().As<IValidacaoDelAuthGrupoXAcesso>();
            #endregion

            #region IOC Utils
            builder.RegisterType<GeraToken>().As<IGeraToken>();
            #endregion
        }
    }
}
