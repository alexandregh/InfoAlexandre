using System;
using System.Collections.Generic;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDCursos;
using InfoAlexandre.SGBD.Repository.RepositoryBases;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace InfoAlexandre.SGBD.Repository.RepositoryEntity.RepositoryEntityCursos
{
    public class RepositoryEntityCurso : RepositoryBase<Cursos>, IContractsSGBDCurso
    {
        #region Implementação dos Métodos do Curso

        public Cursos PesquisarCursoPorNomePersistence(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select c.Nome as nomeCurso, c.Instituicao, c.CargaHoraria, c.Link, c.TipoAula, c.Status," +
                                         " c.Status, c.Certificado, c.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbcurso c inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.Nome = @Nome";
                        var curso = conexaoBD.QueryFirst<Cursos>(query, new { Nome = nome });
                        return curso;
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

        public IReadOnlyCollection<Cursos> PesquisarCursosPorCargaHorariaPersistence(int cargahoraria)
        {
            if (cargahoraria != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select c.Nome as nomeCurso, c.Instituicao, c.CargaHoraria, c.Link, c.TipoAula, c.Status," +
                                         " c.Status, c.Certificado, c.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbcurso c inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.CargaHoraria = @CargaHoraria";
                        var curso = conexaoBD.Query<Cursos>(query, new { CargaHoraria = cargahoraria });
                        return (IReadOnlyCollection<Cursos>)curso;
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

        public IReadOnlyCollection<Cursos> PesquisarCursosPorCertificadoPersistence(bool certificado)
        {            
            try
            {
                using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                {
                    conexaoBD.Open();
                    string query = "select c.Nome as nomeCurso, c.Instituicao, c.CargaHoraria, c.Link, c.TipoAula, c.Status," +
                                        " c.Status, c.Certificado, c.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                        " from tbcurso c inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                        " where f.certificado = @certificado";
                    var curso = conexaoBD.Query<Cursos>(query, new { Certificado = certificado });
                    return (IReadOnlyCollection<Cursos>)curso;
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

        public IReadOnlyCollection<Cursos> PesquisarCursosPorInstituicaoPersistence(string instituicao)
        {
            if (!string.IsNullOrEmpty(instituicao))
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select c.Nome as nomeCurso, c.Instituicao, c.CargaHoraria, c.Link, c.TipoAula, c.Status," +
                                         " c.Status, c.Certificado, c.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbcurso c inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.Instituicao = @Instituicao";
                        var curso = conexaoBD.Query<Cursos>(query, new { Instituicao = instituicao });
                        return (IReadOnlyCollection<Cursos>)curso;
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

        public IReadOnlyCollection<Cursos> PesquisarCursosPorStatusPersistence(Status status)
        {
            if (status != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select c.Nome as nomeCurso, c.Instituicao, c.CargaHoraria, c.Link, c.TipoAula, c.Status," +
                                         " c.Status, c.Certificado, c.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbcurso c inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.Status = @Status";
                        var curso = conexaoBD.Query<Cursos>(query, new { Status = status });
                        return (IReadOnlyCollection<Cursos>)curso;
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

        public IReadOnlyCollection<Cursos> PesquisarCursosPorTipoAulaPersistence(TipoAula tipoaula)
        {
            if (tipoaula != 0)
            {
                try
                {
                    using (SqlConnection conexaoBD = new SqlConnection(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString))
                    {
                        conexaoBD.Open();
                        string query = "select c.Nome as nomeCurso, c.Instituicao, c.CargaHoraria, c.Link, c.TipoAula, c.Status," +
                                         " c.Status, c.Certificado, c.Descricao, ca.Nome as nomeCategoria, ca.Descricao" +
                                         " from tbcurso c inner join tbcategoria ca on c.IdCategoria = ca.IdCategoria" +
                                         " where f.Tipoaula = @Tipoaula";
                        var curso = conexaoBD.Query<Cursos>(query, new { Tipoaula = tipoaula });
                        return (IReadOnlyCollection<Cursos>)curso;
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