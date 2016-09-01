using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDBases;
using System.Collections.Generic;

namespace InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDCursos
{
    public interface IContractsSGBDCurso : IContractsSGBDBase<Cursos>
    {
        #region Interface dos Métodos dos Cursos

        Cursos PesquisarCursoPorNomePersistence(string nome);
        IReadOnlyCollection<Cursos> PesquisarCursosPorInstituicaoPersistence(string instituicao);
        IReadOnlyCollection<Cursos> PesquisarCursosPorCargaHorariaPersistence(int cargahoraria);
        IReadOnlyCollection<Cursos> PesquisarCursosPorTipoAulaPersistence(TipoAula tipoaula);
        IReadOnlyCollection<Cursos> PesquisarCursosPorCertificadoPersistence(bool certificado);
        IReadOnlyCollection<Cursos> PesquisarCursosPorStatusPersistence(Status status);

        #endregion
    }
}