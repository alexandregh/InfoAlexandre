using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDBases;
using System.Collections.Generic;

namespace InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDFormacoes
{
    public interface IContractsSGBDFormacao : IContractsSGBDBase<Formacoes>
    {
        #region Interface dos Métodos das Formações

        Formacoes PesquisarFormacaoPorNomePersistence(string nome);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorInstituicaoPersistence(string instituicao);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCargaHorariaPersistence(int cargahoraria);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoAulaPersistence(TipoAula tipoaula);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoEnsinoPersistence(TipoEnsino tipoensino);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCertificadoPersistence(bool certificado);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorStatusPersistence(Status status);

        #endregion
    }
}