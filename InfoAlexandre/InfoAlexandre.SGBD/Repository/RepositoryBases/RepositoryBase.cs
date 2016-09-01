using System;
using System.Collections.Generic;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDBases;
using InfoAlexandre.SGBD.Context;
using System.Transactions;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace InfoAlexandre.SGBD.Repository.RepositoryBases
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IContractsSGBDBase<TEntity> where TEntity : class
    {
        #region Atributos

        protected DataContext dataContext;

        #endregion

        #region Construtor

        public RepositoryBase()
        {
            dataContext = new DataContext();
        }

        #endregion

        #region Implementação dos Métodos Base

        public void InserirPersistence(TEntity entity)
        {
            if(entity != null)
            {
                if(dataContext != null)
                {
                    try
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        { 
                            dataContext.Entry(entity).State = EntityState.Added;
                            dataContext.SaveChanges();
                            transactionScope.Complete();
                        }
                    }
                    catch (DbEntityValidationException ex)
                    {
                        throw new DbEntityValidationException(nameof(ex.Message));
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        throw new DbUpdateConcurrencyException(nameof(ex.Message));
                    }
                    catch (DbUpdateException ex)
                    {
                        throw new DbUpdateException(nameof(ex.Message));
                    }
                    catch (ObjectDisposedException ex)
                    {
                        throw new ObjectDisposedException(nameof(ex.Message));
                    }
                    catch (NotSupportedException ex)
                    {
                        throw new NotSupportedException(nameof(ex.Message));
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw new InvalidOperationException(nameof(ex.Message));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(nameof(ex.Message));
                    }
                }
                else
                {
                    dataContext = new DataContext();
                    try
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        {
                            dataContext.Entry(entity).State = EntityState.Added;
                            dataContext.SaveChanges();
                            transactionScope.Complete();
                        }
                    }
                    catch (DbEntityValidationException ex)
                    {
                        throw new DbEntityValidationException(nameof(ex.Message));
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        throw new DbUpdateConcurrencyException(nameof(ex.Message));
                    }
                    catch (DbUpdateException ex)
                    {
                        throw new DbUpdateException(nameof(ex.Message));
                    }
                    catch (ObjectDisposedException ex)
                    {
                        throw new ObjectDisposedException(nameof(ex.Message));
                    }
                    catch (NotSupportedException ex)
                    {
                        throw new NotSupportedException(nameof(ex.Message));
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw new InvalidOperationException(nameof(ex.Message));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(nameof(ex.Message));
                    }
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
            }
        }

        public void AtualizarPersistence(TEntity entity)
        {
            if (entity != null)
            {
                if (dataContext != null)
                {
                    try
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        {
                            dataContext.Entry(entity).State = EntityState.Modified;
                            dataContext.SaveChanges();
                            transactionScope.Complete();
                        }
                    }
                    catch (DbEntityValidationException ex)
                    {
                        throw new DbEntityValidationException(nameof(ex.Message));
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        throw new DbUpdateConcurrencyException(nameof(ex.Message));
                    }
                    catch (DbUpdateException ex)
                    {
                        throw new DbUpdateException(nameof(ex.Message));
                    }
                    catch (ObjectDisposedException ex)
                    {
                        throw new ObjectDisposedException(nameof(ex.Message));
                    }
                    catch (NotSupportedException ex)
                    {
                        throw new NotSupportedException(nameof(ex.Message));
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw new InvalidOperationException(nameof(ex.Message));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(nameof(ex.Message));
                    }
                }
                else
                {
                    dataContext = new DataContext();
                    try
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        {
                            dataContext.Entry(entity).State = EntityState.Modified;
                            dataContext.SaveChanges();
                            transactionScope.Complete();
                        }
                    }
                    catch (DbEntityValidationException ex)
                    {
                        throw new DbEntityValidationException(nameof(ex.Message));
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        throw new DbUpdateConcurrencyException(nameof(ex.Message));
                    }
                    catch (DbUpdateException ex)
                    {
                        throw new DbUpdateException(nameof(ex.Message));
                    }
                    catch (ObjectDisposedException ex)
                    {
                        throw new ObjectDisposedException(nameof(ex.Message));
                    }
                    catch (NotSupportedException ex)
                    {
                        throw new NotSupportedException(nameof(ex.Message));
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw new InvalidOperationException(nameof(ex.Message));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(nameof(ex.Message));
                    }
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
            }
        }

        public void ExcluirPersistence(TEntity entity)
        {
            if (entity != null)
            {
                if (dataContext != null)
                {
                    try
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        {
                            dataContext.Entry(entity).State = EntityState.Deleted;
                            dataContext.SaveChanges();
                            transactionScope.Complete();
                        }
                    }
                    catch (DbEntityValidationException ex)
                    {
                        throw new DbEntityValidationException(nameof(ex.Message));
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        throw new DbUpdateConcurrencyException(nameof(ex.Message));
                    }
                    catch (DbUpdateException ex)
                    {
                        throw new DbUpdateException(nameof(ex.Message));
                    }
                    catch (ObjectDisposedException ex)
                    {
                        throw new ObjectDisposedException(nameof(ex.Message));
                    }
                    catch (NotSupportedException ex)
                    {
                        throw new NotSupportedException(nameof(ex.Message));
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw new InvalidOperationException(nameof(ex.Message));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(nameof(ex.Message));
                    }
                }
                else
                {
                    dataContext = new DataContext();
                    try
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        {
                            dataContext.Entry(entity).State = EntityState.Deleted;
                            dataContext.SaveChanges();
                            transactionScope.Complete();
                        }
                    }
                    catch (DbEntityValidationException ex)
                    {
                        throw new DbEntityValidationException(nameof(ex.Message));
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        throw new DbUpdateConcurrencyException(nameof(ex.Message));
                    }
                    catch (DbUpdateException ex)
                    {
                        throw new DbUpdateException(nameof(ex.Message));
                    }
                    catch (ObjectDisposedException ex)
                    {
                        throw new ObjectDisposedException(nameof(ex.Message));
                    }
                    catch (NotSupportedException ex)
                    {
                        throw new NotSupportedException(nameof(ex.Message));
                    }
                    catch (InvalidOperationException ex)
                    {
                        throw new InvalidOperationException(nameof(ex.Message));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(nameof(ex.Message));
                    }
                }
                dataContext.Dispose();
            }
            else
            {
                this.Dispose(true);
            }
        }

        public TEntity PesquisarPorIdPersistence(byte id)
        {
            try
            {
                TEntity entidade = dataContext.Set<TEntity>().AsParallel().FirstOrDefault();
                return entidade;
            }
            catch (AggregateException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (OperationCanceledException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public TEntity PesquisarPorIdPersistence(int id)
        {
            try
            {
                TEntity entidade = dataContext.Set<TEntity>().AsParallel().FirstOrDefault();
                return entidade;
            }
            catch (AggregateException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (OperationCanceledException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        public IReadOnlyCollection<TEntity> PesquisarTodosPersistence()
        {
            try
            {
                IReadOnlyCollection<TEntity> entidade = dataContext.Set<TEntity>().AsParallel().ToList();
                return entidade;
            }
            catch (AggregateException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (OperationCanceledException ex)
            {
                throw new Exception(nameof(ex.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(ex.Message));
            }
        }

        #endregion

        #region Implementação da Interface IDisposable

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                
            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}