using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.DomainServices.DomainServicesBases;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDCategorias;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesCategorias;

namespace InfoAlexandre.Domain.DomainServices.DomainServicesEntity.DomainServicesCategorias
{
    public class DomainServicesCategoria : DomainServicesBase<Categorias>, IContractsDomainServicesCategoria
    {
        #region Atributos

        private IContractsSGBDCategoria domainServicesCategoria;

        #endregion

        #region Construtor

        public DomainServicesCategoria(IContractsSGBDCategoria domainServicesCategoria)
            : base(domainServicesCategoria)
        {
            this.domainServicesCategoria = domainServicesCategoria;
        }

        #endregion

        #region Implementação dos Métodos da Categoria



        #endregion
    }
}