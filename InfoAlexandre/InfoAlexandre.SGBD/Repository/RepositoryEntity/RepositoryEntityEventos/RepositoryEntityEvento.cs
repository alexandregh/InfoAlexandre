using System;
using System.Collections.Generic;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEventos;
using InfoAlexandre.SGBD.Repository.RepositoryBases;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace InfoAlexandre.SGBD.Repository.RepositoryEntity.RepositoryEntityEventos
{
    public class RepositoryEntityEvento : RepositoryBase<Eventos>, IContractsSGBDEvento
    {
        #region Implementação dos Métodos do Evento

        public Eventos PesquisarEventoPorNomePersistence(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select e.Nome as nomeEvento, e.Instituicao, e.CargaHoraria, e.Link, e.TipoAula, e.Data," +
                                         " e.TipoAula, e.Certificado, e.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbevento e inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.Nome = @Nome";
                        var evento = conexaoBD.QueryFirst<Eventos>(query, new { Nome = nome });
                        return evento;
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

        public Eventos PesquisarEventoPorDataPersistence(DateTime data)
        {
            if (data != null)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select e.Nome as nomeEvento, e.Instituicao, e.CargaHoraria, e.Link, e.TipoAula, e.Data," +
                                         " e.TipoAula, e.Certificado, e.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbevento e inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.Data = @Data";
                        var evento = conexaoBD.QueryFirst<Eventos>(query, new { Data = data });
                        return evento;
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

        public IReadOnlyCollection<Eventos> PesquisarEventosPorCargaHorariaPersistence(int cargahoraria)
        {
            if (cargahoraria != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select e.Nome as nomeEvento, e.Instituicao, e.CargaHoraria, e.Link, e.TipoAula, e.Data," +
                                         " e.TipoAula, e.Certificado, e.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbevento e inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.CargaHoraria = @CargaHoraria";
                        var evento = conexaoBD.Query<Eventos>(query, new { CargaHoraria = cargahoraria });
                        return (IReadOnlyCollection<Eventos>)evento;
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

        public IReadOnlyCollection<Eventos> PesquisarEventosPorCertificadoPersistence(bool certificado)
        {            
            try
            {
                using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                {
                    conexaoBD.Open();
                    string query = "select e.Nome as nomeEvento, e.Instituicao, e.CargaHoraria, e.Link, e.TipoAula, e.Data," +
                                        " e.TipoAula, e.Certificado, e.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                        " from tbevento e inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                        " where f.Certificado = @Certificado";
                    var evento = conexaoBD.Query<Eventos>(query, new { Certificado = certificado });
                    return (IReadOnlyCollection<Eventos>)evento;
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

        public IReadOnlyCollection<Eventos> PesquisarEventosPorInstituicaoPersistence(string instituicao)
        {
            if (!string.IsNullOrEmpty(instituicao))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select e.Nome as nomeEvento, e.Instituicao, e.CargaHoraria, e.Link, e.TipoAula, e.Data," +
                                         " e.TipoAula, e.Certificado, e.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbevento e inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.Instituicao = @Instituicao";
                        var evento = conexaoBD.Query<Eventos>(query, new { Instituicao = instituicao });
                        return (IReadOnlyCollection<Eventos>)evento;
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

        public IReadOnlyCollection<Eventos> PesquisarEventosPorStatusPersistence(Status status)
        {
            if (status != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select e.Nome as nomeEvento, e.Instituicao, e.CargaHoraria, e.Link, e.TipoAula, e.Data," +
                                         " e.TipoAula, e.Certificado, e.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbevento e inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.Status = @Status";
                        var evento = conexaoBD.Query<Eventos>(query, new { Status = status });
                        return (IReadOnlyCollection<Eventos>)evento;
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

        public IReadOnlyCollection<Eventos> PesquisarEventosPorTipoAulaPersistence(TipoAula tipoaula)
        {
            if (tipoaula != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select e.Nome as nomeEvento, e.Instituicao, e.CargaHoraria, e.Link, e.TipoAula, e.Data," +
                                         " e.TipoAula, e.Certificado, e.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbevento e inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.TipoAula = @TipoAula";
                        var evento = conexaoBD.Query<Eventos>(query, new { TipoAula = tipoaula });
                        return (IReadOnlyCollection<Eventos>)evento;
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