using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using System.Collections.Generic;

namespace InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesCursos
{
    public interface IContractsDomainServicesCurso : IContractsDomainServicesBase<Cursos>
    {
        #region Interface dos Métodos do Curso

        Cursos PesquisarCursoPorNomeServices(string nome);
        IReadOnlyCollection<Cursos> PesquisarCursosPorInstituicaoServices(string instituicao);
        IReadOnlyCollection<Cursos> PesquisarCursosPorCargaHorariaServices(int cargahoraria);
        IReadOnlyCollection<Cursos> PesquisarCursosPorTipoAulaServices(TipoAula tipoaula);
        IReadOnlyCollection<Cursos> PesquisarCursosPorCertificadoServices(bool certificado);
        IReadOnlyCollection<Cursos> PesquisarCursosPorStatusServices(Status status);

        #endregion
    }
}