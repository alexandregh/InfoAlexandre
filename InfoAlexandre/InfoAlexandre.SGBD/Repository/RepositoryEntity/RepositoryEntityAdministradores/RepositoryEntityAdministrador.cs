using System;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAdministradores;
using InfoAlexandre.SGBD.Repository.RepositoryBases;
using System.Data.SqlClient;
using Dapper;
using System.Configuration;

namespace InfoAlexandre.SGBD.Repository.RepositoryEntity.RepositoryEntityAdministradores
{
    public class RepositoryEntityAdministrador : RepositoryBase<Administradores>, IContractsSGBDAdministrador
    {
        #region Implementação dos Métodos do Administrador

        public Administradores PesquisarAdministradorPorNomePersistence(string nome)
        {
            if(!string.IsNullOrEmpty(nome))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select Nome, Sobrenome, Login, DataCadastro, DataAlteracao, Descricao" +
                                        " from tbadministrador where Nome = @Nome";
                        var administrador = conexaoBD.QueryFirst<Administradores>(query, new { Nome = nome });
                        return administrador;
                    }
                }
                catch (OperationCanceledException ex)
                {
                    throw new OperationCanceledException(nameof(ex.Message));
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (AggregateException ex)
                {
                    throw new AggregateException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        public Administradores PesquisaAdministradorPorSobrenomePersistence(string sobrenome)
        {
            if (!string.IsNullOrEmpty(sobrenome))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select Nome, Sobrenome, Login, DataCadastro, DataAlteracao, Descricao" +
                                        " from tbadministrador where Sobrenome = @Sobrenome";
                        var administrador = conexaoBD.QueryFirst<Administradores>(query, new { Sobrenome = sobrenome });
                        return administrador;
                    }
                }
                catch (OperationCanceledException ex)
                {
                    throw new OperationCanceledException(nameof(ex.Message));
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (AggregateException ex)
                {
                    throw new AggregateException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        public Administradores PesquisaAdministradorPorLoginSenhaPersistence(string login, string senha)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select Nome, Sobrenome, Login, DataCadastro, DataAlteracao, Descricao" +
                                        " from tbadministrador where Login = @Login and Senha = @Senha";
                        var administrador = conexaoBD.QueryFirst<Administradores>(query, new { Login = login, Senha = senha });
                        return administrador;
                    }
                }
                catch (OperationCanceledException ex)
                {
                    throw new OperationCanceledException(nameof(ex.Message));
                }
                catch (ArgumentNullException ex)
                {
                    throw new ArgumentNullException(nameof(ex.Message));
                }
                catch (AggregateException ex)
                {
                    throw new AggregateException(nameof(ex.Message));
                }
                catch (Exception ex)
                {
                    throw new Exception(nameof(ex.Message));
                }
            }
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        #endregion
    }
}