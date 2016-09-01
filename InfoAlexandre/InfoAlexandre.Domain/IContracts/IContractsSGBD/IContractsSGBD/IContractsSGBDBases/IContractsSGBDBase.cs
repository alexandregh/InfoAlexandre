using System.Collections.Generic;

namespace InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDBases
{
    public interface IContractsSGBDBase<TEntity> where TEntity : class
    {
        #region Interfaces dos Métodos Base

        void InserirPersistence(TEntity entity);
        void AtualizarPersistence(TEntity entity);
        void ExcluirPersistence(TEntity entity);
        TEntity PesquisarPorIdPersistence(int id);
        TEntity PesquisarPorIdPersistence(byte id);
        IReadOnlyCollection<TEntity> PesquisarTodosPersistence();

        #endregion
    }
}