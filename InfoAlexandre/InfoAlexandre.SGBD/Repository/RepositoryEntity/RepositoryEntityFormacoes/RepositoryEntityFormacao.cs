using System;
using System.Collections.Generic;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDFormacoes;
using InfoAlexandre.SGBD.Repository.RepositoryBases;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using InfoAlexandre.Domain.Domain.Enum;

namespace InfoAlexandre.SGBD.Repository.RepositoryEntity.RepositoryEntityFormacoes
{
    public class RepositoryEntityFormacao : RepositoryBase<Formacoes>, IContractsSGBDFormacao
    {
        #region Implementação dos Métodos da Formação

        public Formacoes PesquisarFormacaoPorNomePersistence(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select f.Nome as nomeFormacao, f.Instituicao, f.CargaHoraria, f.Link, f.TipoAula, f.TipoEnsino," +
                                        " f.Status, f.Certificado, f.Descricao, c.Nome as nomeCategoria, c.Descricao" +
                                        " from tbformacao f inner join tbcategoria c on f.IdCategoria = c.IdCategoria" +
                                        " where f.Nome = @Nome";
                        var formacao = conexaoBD.QueryFirst<Formacoes>(query, new { Nome = nome });
                        return formacao;
                    }
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
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorInstituicaoPersistence(string instituicao)
        {
            if (!string.IsNullOrEmpty(instituicao))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select f.Nome as nomeFormacao, f.Instituicao, f.CargaHoraria, f.Link, f.TipoAula, f.TipoEnsino," +
                                         " f.Status, f.Certificado, f.Descricao, c.Nome as nomeCategoria, c.Descricao" +
                                         " from tbformacao f inner join tbcategoria c on f.IdCategoria = c.IdCategoria" +
                                         " where f.Instituicao = @Instituicao";
                        var formacao = conexaoBD.Query<Formacoes>(query, new { Instituicao = instituicao });
                        return (IReadOnlyCollection<Formacoes>)formacao;
                    }
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
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCargaHorariaPersistence(int cargahoraria)
        {
            if (cargahoraria != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select f.Nome as nomeFormacao, f.Instituicao, f.CargaHoraria, f.Link, f.TipoAula, f.TipoEnsino," +
                                         " f.Status, f.Certificado, f.Descricao, c.Nome as nomeCategoria, c.Descricao" +
                                         " from tbformacao f inner join tbcategoria c on f.IdCategoria = c.IdCategoria" +
                                         " where f.CargaHoraria = @CargaHoraria";
                        var formacao = conexaoBD.Query<Formacoes>(query, new { CargaHoraria = cargahoraria });
                        return (IReadOnlyCollection<Formacoes>)formacao;
                    }
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
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoAulaPersistence(TipoAula tipoaula)
        {
            if (tipoaula != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select f.Nome as nomeFormacao, f.Instituicao, f.CargaHoraria, f.Link, f.TipoAula, f.TipoEnsino," +
                                         " f.Status, f.Certificado, f.Descricao, c.Nome as nomeCategoria, c.Descricao" +
                                         " from tbformacao f inner join tbcategoria c on f.IdCategoria = c.IdCategoria" +
                                         " where f.TipoAula = @TipoAula";
                        var formacao = conexaoBD.Query<Formacoes>(query, new { TipoAula = tipoaula });
                        return (IReadOnlyCollection<Formacoes>)formacao;
                    }
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
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoEnsinoPersistence(TipoEnsino tipoensino)
        {
            if (tipoensino != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select f.Nome as nomeFormacao, f.Instituicao, f.CargaHoraria, f.Link, f.TipoAula, f.TipoEnsino," +
                                         " f.Status, f.Certificado, f.Descricao, c.Nome as nomeCategoria, c.Descricao" +
                                         " from tbformacao f inner join tbcategoria c on f.IdCategoria = c.IdCategoria" +
                                         " where f.TipoEnsino = @TipoEnsino";
                        var formacao = conexaoBD.Query<Formacoes>(query, new { TipoEnsino = tipoensino });
                        return (IReadOnlyCollection<Formacoes>)formacao;
                    }
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
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCertificadoPersistence(bool certificado)
        {            
            try
            {
                using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                {
                    conexaoBD.Open();
                    string query = "select f.Nome as nomeFormacao, f.Instituicao, f.CargaHoraria, f.Link, f.TipoAula, f.TipoEnsino," +
                                        " f.Status, f.Certificado, f.Descricao, c.Nome as nomeCategoria, c.Descricao" +
                                        " from tbformacao f inner join tbcategoria c on f.IdCategoria = c.IdCategoria" +
                                        " where f.Certificado = @Certificado";
                    var formacao = conexaoBD.Query<Formacoes>(query, new { Certificado = certificado });
                    return (IReadOnlyCollection<Formacoes>)formacao;
                }
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

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorStatusPersistence(Status status)
        {
            if (status != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select f.Nome as nomeFormacao, f.Instituicao, f.CargaHoraria, f.Link, f.TipoAula, f.TipoEnsino," +
                                         " f.Status, f.Certificado, f.Descricao, c.Nome as nomeCategoria, c.Descricao" +
                                         " from tbformacao f inner join tbcategoria c on f.IdCategoria = c.IdCategoria" +
                                         " where f.Status = @Status";
                        var formacao = conexaoBD.Query<Formacoes>(query, new { Status = status });
                        return (IReadOnlyCollection<Formacoes>)formacao;
                    }
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
            else
            {
                this.Dispose(true);
            }
            return null;
        }

        #endregion
    }
}