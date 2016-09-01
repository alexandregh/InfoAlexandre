using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesBases;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using System.Collections.Generic;

namespace InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesCursos
{
    public interface IContractsAppServicesCurso : IContractsAppServicesBase<Cursos>
    {
        #region Interface dos Métodos do Curso

        Cursos PesquisarCursoPorNomeServices(string nome);
        IReadOnlyCollection<Cursos> PesquisarCursosPorInstituicaoApp(string instituicao);
        IReadOnlyCollection<Cursos> PesquisarCursosPorCargaHorariaApp(int cargahoraria);
        IReadOnlyCollection<Cursos> PesquisarCursosPorTipoAulaApp(TipoAula tipoaula);
        IReadOnlyCollection<Cursos> PesquisarCursosPorCertificadoApp(bool certificado);
        IReadOnlyCollection<Cursos> PesquisarCursosPorStatusApp(Status status);

        #endregion
    }
}