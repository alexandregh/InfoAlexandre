using InfoAlexandre.App.AppServices.AppServicesBases;
using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesCategorias;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesCategorias;

namespace InfoAlexandre.App.AppServices.AppServicesEntity.AppServicesCategorias
{
    public class AppServicesCategoria : AppServicesBase<Categorias>, IContractsAppServicesCategoria
    {
        #region Atributo

        private IContractsDomainServicesCategoria appServicesCategoria;

        #endregion

        #region Construtor

        public AppServicesCategoria(IContractsDomainServicesCategoria appServicesCategoria)
            : base(appServicesCategoria)
        {
            this.appServicesCategoria = appServicesCategoria;
        }

        #endregion

        #region Implementação dos Métodos da Categoria



        #endregion
    }
}