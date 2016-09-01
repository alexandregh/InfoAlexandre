using System.Collections.Generic;

namespace InfoAlexandre.App.IContractsAppServices.IContractsAppServicesBases
{
    public interface IContractsAppServicesBase<TEntity> where TEntity : class
    {
        #region Interface dos Métodos Base

        void InserirApp(TEntity entity);
        void AtualizarApp(TEntity entity);
        void ExcluirApp(TEntity entity);
        TEntity PesquisarPorIdApp(int id);
        TEntity PesquisarPorIdApp(byte id);
        IReadOnlyCollection<TEntity> PesquisarTodosApp();

        #endregion
    }
}
