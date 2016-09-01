using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.DomainServices.DomainServicesBases;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDFormacoes;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesFormacoes;
using System;
using System.Collections.Generic;
using InfoAlexandre.Domain.Domain.Enum;

namespace InfoAlexandre.Domain.DomainServices.DomainServicesEntity.DomainServicesFormacoes
{
    public class DomainServicesFormacao : DomainServicesBase<Formacoes>, IContractsDomainServicesFormacao
    {
        #region Atributos

        private IContractsSGBDFormacao domainServicesFormacao;

        #endregion

        #region Construtor

        public DomainServicesFormacao(IContractsSGBDFormacao domainServicesFormacao)
            : base(domainServicesFormacao)
        {
            this.domainServicesFormacao = domainServicesFormacao;
        }

        #endregion

        #region Implementação dos Métodos da Formação

        public Formacoes PesquisarFormacaoPorNomeServices(string nome)
        {
            return domainServicesFormacao.PesquisarFormacaoPorNomePersistence(nome);
        }

        public IReadOnlyCollection<Formacoes> PesquisaFormacoesPorInstituicaoServices(string instituicao)
        {
            return domainServicesFormacao.PesquisarFormacoesPorInstituicaoPersistence(instituicao);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCargaHorariaServices(int cargahoraria)
        {
            return domainServicesFormacao.PesquisarFormacoesPorCargaHorariaPersistence(cargahoraria);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoAulaServices(TipoAula tipoaula)
        {
            return domainServicesFormacao.PesquisarFormacoesPorTipoAulaPersistence(tipoaula);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorTipoEnsinoServices(TipoEnsino tipoensino)
        {
            return domainServicesFormacao.PesquisarFormacoesPorTipoEnsinoPersistence(tipoensino);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorCertificadoServices(bool certificado)
        {
            return domainServicesFormacao.PesquisarFormacoesPorCertificadoPersistence(certificado);
        }

        public IReadOnlyCollection<Formacoes> PesquisarFormacoesPorStatusServices(Status status)
        {
            return domainServicesFormacao.PesquisarFormacoesPorStatusPersistence(status);
        }

        #endregion
    }
}