using System.Collections.Generic;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDBases;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using System;

namespace InfoAlexandre.Domain.DomainServices.DomainServicesBases
{
    public abstract class DomainServicesBase<TEntity> : IContractsDomainServicesBase<TEntity> where TEntity : class
    {
        #region Atributos

        private IContractsSGBDBase<TEntity> domainServicesBase;

        #endregion

        #region Construtor

        public DomainServicesBase(IContractsSGBDBase<TEntity> domainServicesBase)
        {
            this.domainServicesBase = domainServicesBase;
        }

        #endregion

        #region Implementação dos Métodos Base

        public void InserirServices(TEntity entity)
        {
            domainServicesBase.InserirPersistence(entity);
        }

        public void AtualizarServices(TEntity entity)
        {
            domainServicesBase.AtualizarPersistence(entity);
        }

        public void ExcluirServices(TEntity entity)
        {
            domainServicesBase.ExcluirPersistence(entity);
        }

        public TEntity PesquisarPorIdServices(int id)
        {
            return domainServicesBase.PesquisarPorIdPersistence(id);
        }

        public TEntity PesquisarPorIdServices(byte id)
        {
            return domainServicesBase.PesquisarPorIdPersistence(id);
        }

        public IReadOnlyCollection<TEntity> PesquisarTodosServices()
        {
            return domainServicesBase.PesquisarTodosPersistence();
        }

        #endregion
    }
}