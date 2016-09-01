using System;
using InfoAlexandre.App.AppServices.AppServicesBases;
using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesFormacoes;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesFormacoes;
using System.Collections.Generic;
using InfoAlexandre.Domain.Domain.Enum;

namespace InfoAlexandre.App.AppServices.AppServicesEntity.AppServicesFormacoes
{
    public class AppServicesFormacao : AppServicesBase<Formacoes>, IContractsAppServicesFormacao
    {
        #region Atributo

        private IContractsDomainServicesFormacao appServicesFormacao;

        #endregion

        #region Construtor

        public AppServicesFormacao(IContractsDomainServicesFormacao appServicesFormacao)
            : base(appServicesFormacao)
        {
            this.appServicesFormacao = appServicesFormacao;
        }

        #endregion

        #region Implementação dos Métodos de Formação

        public IReadOnlyCollection<Formacoes> PesquisaFormacaoPorInstituicaoApp(string instituicao)
        {
            return appServicesFormacao.PesquisaFormacoesPorInstituicaoServices(instituicao);
        }

        public Formacoes PesquisarFormacaoPorNomeApp(string nome)
        {
            return appServicesFormacao.PesquisarFormacaoPorNomeServices(nome);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCargaHorariaApp(int cargahoraria)
        {
            return appServicesFormacao.PesquisarFormacoesPorCargaHorariaServices(cargahoraria);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCertificadoApp(bool certificado)
        {
            return appServicesFormacao.PesquisarFormacoesPorCertificadoServices(certificado);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorStatusApp(Status status)
        {
            return appServicesFormacao.PesquisarFormacoesPorStatusServices(status);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoAulaApp(TipoAula tipoaula)
        {
            return appServicesFormacao.PesquisarFormacoesPorTipoAulaServices(tipoaula);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoEnsinoApp(TipoEnsino tipoensino)
        {
            return appServicesFormacao.PesquisarFormacoesPorTipoEnsinoServices(tipoensino);
        }

        #endregion
    }
}