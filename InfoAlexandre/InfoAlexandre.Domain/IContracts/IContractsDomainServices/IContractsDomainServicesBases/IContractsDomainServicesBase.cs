using System.Collections.Generic;

namespace InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases
{
    public interface IContractsDomainServicesBase<TEntity> where TEntity : class
    {
        #region Interfaces dos Métodos Base

        void InserirServices(TEntity entity);
        void AtualizarServices(TEntity entity);
        void ExcluirServices(TEntity entity);
        TEntity PesquisarPorIdServices(int id);
        TEntity PesquisarPorIdServices(byte id);
        IReadOnlyCollection<TEntity> PesquisarTodosServices();

        #endregion
    }
}