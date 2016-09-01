using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDGrupos;
using InfoAlexandre.Domain.DomainServices.DomainServicesBases;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesGrupos;

namespace InfoAlexandre.Domain.DomainServices.DomainServicesEntity.DomainServicesGrupos
{
    public class DomainServicesGrupo : DomainServicesBase<Grupos>, IContractsDomainServicesGrupo
    {
        #region Atributo

        private IContractsSGBDGrupo domainServicesGrupo;

        #endregion

        #region Construtor

        public DomainServicesGrupo(IContractsSGBDGrupo domainServicesGrupo)
            : base(domainServicesGrupo)
        {
            this.domainServicesGrupo = domainServicesGrupo;
        }

        #endregion

        #region Implementação dos Métodos do Grupo

        

        #endregion
    }
}