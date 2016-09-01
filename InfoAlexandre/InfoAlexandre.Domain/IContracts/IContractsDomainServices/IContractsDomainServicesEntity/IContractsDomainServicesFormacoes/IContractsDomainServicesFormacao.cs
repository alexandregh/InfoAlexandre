using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using System.Collections.Generic;

namespace InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesFormacoes
{
    public interface IContractsDomainServicesFormacao : IContractsDomainServicesBase<Formacoes>
    {
        #region Interface dos Métodos do Formação

        Formacoes PesquisarFormacaoPorNomeServices(string nome);
        IReadOnlyCollection<Formacoes> PesquisaFormacoesPorInstituicaoServices(string instituicao);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCargaHorariaServices(int cargahoraria);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoAulaServices(TipoAula tipoaula);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoEnsinoServices(TipoEnsino tipoensino);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCertificadoServices(bool certificado);
        IReadOnlyCollection<Formacoes> PesquisarFormacoesPorStatusServices(Status status);

        #endregion
    }
}