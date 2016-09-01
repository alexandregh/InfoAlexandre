using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesBases;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using System.Collections.Generic;

namespace InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesFormacoes
{
    public interface IContractsAppServicesFormacao : IContractsAppServicesBase<Formacoes>
    {
        #region Interface dos Métodos da Formação

        Formacoes PesquisarFormacaoPorNomeApp(string nome);
        IReadOnlyCollection<Formacoes> PesquisaFormacaoPorInstituicaoApp(string instituicao);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCargaHorariaApp(int cargahoraria);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoAulaApp(TipoAula tipoaula);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoEnsinoApp(TipoEnsino tipoensino);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCertificadoApp(bool certificado);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorStatusApp(Status status);

        #endregion
    }
}