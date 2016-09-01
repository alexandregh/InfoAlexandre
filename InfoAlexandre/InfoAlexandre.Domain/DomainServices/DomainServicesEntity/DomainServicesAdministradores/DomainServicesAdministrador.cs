using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.DomainServices.DomainServicesBases;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAdministradores;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAdministradores;
using System;

namespace InfoAlexandre.Domain.DomainServices.DomainServicesEntity.DomainServicesAdministradores
{
    public class DomainServicesAdministrador : DomainServicesBase<Administradores>, IContractsDomainServicesAdministrador
    {
        #region Atributos

        private IContractsSGBDAdministrador domainServicesAdministrador;

        #endregion

        #region Construtor

        public DomainServicesAdministrador(IContractsSGBDAdministrador domainServicesAdministrador)
            : base(domainServicesAdministrador)
        {
            this.domainServicesAdministrador = domainServicesAdministrador;
        }

        #endregion

        #region Implementação dos Métodos do Administrador

        public Administradores PesquisaAdministradorPorLoginSenhaServices(string login, string senha)
        {
            return domainServicesAdministrador.PesquisaAdministradorPorLoginSenhaPersistence(login, senha);
        }

        public Administradores PesquisaAdministradorPorSobrenomeServices(string sobrenome)
        {
            return domainServicesAdministrador.PesquisaAdministradorPorSobrenomePersistence(sobrenome);
        }

        public Administradores PesquisarAdministradorPorNomeServices(string nome)
        {
            return domainServicesAdministrador.PesquisarAdministradorPorNomePersistence(nome);
        }

        #endregion
    }
}