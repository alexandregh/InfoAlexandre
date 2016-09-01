using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.DomainServices.DomainServicesBases;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDCursos;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesCursos;
using InfoAlexandre.Domain.Domain.Enum;
using System.Collections.Generic;

namespace InfoAlexandre.Domain.DomainServices.DomainServicesEntity.DomainServicesCursos
{
    public class DomainServicesCurso : DomainServicesBase<Cursos>, IContractsDomainServicesCurso
    {
        #region Atributos

        private IContractsSGBDCurso domainServicesCurso;

        #endregion

        #region Construtor

        public DomainServicesCurso(IContractsSGBDCurso domainServicesCurso)
            : base(domainServicesCurso)
        {
            this.domainServicesCurso = domainServicesCurso;
        }

        #endregion

        #region Implementação dos Métodos do Curso

        public Cursos PesquisarCursoPorNomeServices(string nome)
        {
            return domainServicesCurso.PesquisarCursoPorNomePersistence(nome);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorCargaHorariaServices(int cargahoraria)
        {
            return domainServicesCurso.PesquisarCursosPorCargaHorariaPersistence(cargahoraria);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorCertificadoServices(bool certificado)
        {
            return domainServicesCurso.PesquisarCursosPorCertificadoPersistence(certificado);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorInstituicaoServices(string instituicao)
        {
            return domainServicesCurso.PesquisarCursosPorInstituicaoPersistence(instituicao);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorStatusServices(Status status)
        {
            return domainServicesCurso.PesquisarCursosPorStatusPersistence(status);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorTipoAulaServices(TipoAula tipoaula)
        {
            return domainServicesCurso.PesquisarCursosPorTipoAulaPersistence(tipoaula);
        }

        #endregion
    }
}