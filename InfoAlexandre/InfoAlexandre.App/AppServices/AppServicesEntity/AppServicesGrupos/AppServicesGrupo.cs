using InfoAlexandre.App.AppServices.AppServicesBases;
using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesGrupos;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesGrupos;

namespace InfoAlexandre.App.AppServices.AppServicesEntity.AppServicesGrupos
{
    public class AppServicesGrupo : AppServicesBase<Grupos>, IContractsAppServicesGrupo
    {
        #region Atributo

        private IContractsDomainServicesGrupo appServicesGrupo;

        #endregion

        #region Construtor

        public AppServicesGrupo(IContractsDomainServicesGrupo appServicesGrupo)
            : base(appServicesGrupo)
        {
            this.appServicesGrupo = appServicesGrupo;
        }

        #endregion

        #region Implementação dos Métodos do Grupo



        #endregion
    }
}