using InfoAlexandre.App.AppServices.AppServicesBases;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAdministradores;
using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAdministradores;
using System;

namespace InfoAlexandre.App.AppServices.AppServicesEntity.AppServicesAdministradores
{
    public class AppServicesAdministrador : AppServicesBase<Administradores>, IContractsAppServicesAdministrador
    {
        #region Atributo

        private IContractsDomainServicesAdministrador appServicesAdministrador;

        #endregion

        #region Construtor

        public AppServicesAdministrador(IContractsDomainServicesAdministrador appServicesAdministrador)
            : base(appServicesAdministrador)
        {
            this.appServicesAdministrador = appServicesAdministrador;
        }

        #endregion

        #region Implementação dos Métodos do Administrador

        public Administradores PesquisaAdministradorPorLoginSenhaApp(string login, string senha)
        {
            return appServicesAdministrador.PesquisaAdministradorPorLoginSenhaServices(login, senha);
        }

        public Administradores PesquisaAdministradorPorSobrenomeApp(string sobrenome)
        {
            return appServicesAdministrador.PesquisaAdministradorPorSobrenomeServices(sobrenome);
        }

        public Administradores PesquisarAdministradorPorNomeApp(string nome)
        {
            return appServicesAdministrador.PesquisarAdministradorPorNomeServices(nome);
        }

        #endregion
    }
}