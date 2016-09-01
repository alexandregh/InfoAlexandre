using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesBases;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using System.Collections.Generic;

namespace InfoAlexandre.App.AppServices.AppServicesBases
{
    public abstract class AppServicesBase<TEntity> : IContractsAppServicesBase<TEntity> where TEntity : class
    {
        #region Atributo

        private IContractsDomainServicesBase<TEntity> appServicesBase;

        #endregion

        #region Construtor

        public AppServicesBase(IContractsDomainServicesBase<TEntity> appServicesBase)
        {
            this.appServicesBase = appServicesBase;
        }

        #endregion

        #region Implementação dos Métodos Base

        public void InserirApp(TEntity entity)
        {            
            appServicesBase.InserirServices(entity);
        }

        public void AtualizarApp(TEntity entity)
        {
            appServicesBase.AtualizarServices(entity);
        }

        public void ExcluirApp(TEntity entity)
        {
            appServicesBase.ExcluirServices(entity);
        }

        public TEntity PesquisarPorIdApp(byte id)
        {            
            return appServicesBase.PesquisarPorIdServices(id);
        }

        public TEntity PesquisarPorIdApp(int id)
        {            
            return appServicesBase.PesquisarPorIdServices(id);
        }

        public IReadOnlyCollection<TEntity> PesquisarTodosApp()
        {            
            return appServicesBase.PesquisarTodosServices();
        }

        #endregion
    }
}