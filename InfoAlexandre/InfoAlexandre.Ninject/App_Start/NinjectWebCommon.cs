[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(InfoAlexandre.Ninject.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(InfoAlexandre.Ninject.App_Start.NinjectWebCommon), "Stop")]

namespace InfoAlexandre.Ninject.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using App.IContractsAppServices.IContractsAppServicesBases;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using global::Ninject.Web.Common;
    using global::Ninject;
    using App.AppServices.AppServicesBases;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAdministradores;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesCategorias;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesCursos;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEventos;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesFormacoes;
    using App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesGrupos;
    using App.AppServices.AppServicesEntity.AppServicesAdministradores;
    using App.AppServices.AppServicesEntity.AppServicesCategorias;
    using App.AppServices.AppServicesEntity.AppServicesCursos;
    using App.AppServices.AppServicesEntity.AppServicesEventos;
    using App.AppServices.AppServicesEntity.AppServicesFormacoes;
    using App.AppServices.AppServicesEntity.AppServicesGrupos;
    using Domain.DomainServices.DomainServicesBases;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAdministradores;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesCategorias;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesCursos;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEventos;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesFormacoes;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesGrupos;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesAdministradores;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesCategorias;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesCursos;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesEventos;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesFormacoes;
    using Domain.DomainServices.DomainServicesEntity.DomainServicesGrupos;
    using Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDBases;
    using Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
    using Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAdministradores;
    using Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDCategorias;
    using Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDCursos;
    using Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEventos;
    using Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDFormacoes;
    using Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDGrupos;
    using SGBD.Repository.RepositoryBases;
    using SGBD.Repository.RepositoryEntity.RepositoryEntityAdministradores;
    using SGBD.Repository.RepositoryEntity.RepositoryEntityCategorias;
    using SGBD.Repository.RepositoryEntity.RepositoryEntityCursos;
    using SGBD.Repository.RepositoryEntity.RepositoryEntityEventos;
    using SGBD.Repository.RepositoryEntity.RepositoryEntityFormacoes;
    using SGBD.Repository.RepositoryEntity.RepositoryEntityGrupos;
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                GlobalConfiguration.Configuration.DependencyResolver = kernel.Get<System.Web.Http.Dependencies.IDependencyResolver>();


                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            #region Camada de Aplicação

            kernel.Bind(typeof(IContractsAppServicesBase<>)).To(typeof(AppServicesBase<>));
            kernel.Bind<IContractsAppServicesAdministrador>().To<AppServicesAdministrador>();
            kernel.Bind<IContractsAppServicesCategoria>().To<AppServicesCategoria>();
            kernel.Bind<IContractsAppServicesCurso>().To<AppServicesCurso>();
            kernel.Bind<IContractsAppServicesEvento>().To<AppServicesEvento>();
            kernel.Bind<IContractsAppServicesFormacao>().To<AppServicesFormacao>();
            kernel.Bind<IContractsAppServicesGrupo>().To<AppServicesGrupo>();

            #endregion

            #region Camada de Dominio

            kernel.Bind(typeof(IContractsDomainServicesBase<>)).To(typeof(DomainServicesBase<>));
            kernel.Bind<IContractsDomainServicesAdministrador>().To<DomainServicesAdministrador>();
            kernel.Bind<IContractsDomainServicesCategoria>().To<DomainServicesCategoria>();
            kernel.Bind<IContractsDomainServicesCurso>().To<DomainServicesCurso>();
            kernel.Bind<IContractsDomainServicesEvento>().To<DomainServicesEvento>();
            kernel.Bind<IContractsDomainServicesFormacao>().To<DomainServicesFormacao>();
            kernel.Bind<IContractsDomainServicesGrupo>().To<DomainServicesGrupo>();

            #endregion

            #region Camada de Repositório de Banco de Dados

            kernel.Bind(typeof(IContractsSGBDBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IContractsSGBDAdministrador>().To<RepositoryEntityAdministrador>();
            kernel.Bind<IContractsSGBDCategoria>().To<RepositoryEntityCategoria>();
            kernel.Bind<IContractsSGBDCurso>().To<RepositoryEntityCurso>();
            kernel.Bind<IContractsSGBDEvento>().To<RepositoryEntityEvento>();
            kernel.Bind<IContractsSGBDFormacao>().To<RepositoryEntityFormacao>();
            kernel.Bind<IContractsSGBDGrupo>().To<RepositoryEntityGrupo>();

            #endregion
        }
    }
}
