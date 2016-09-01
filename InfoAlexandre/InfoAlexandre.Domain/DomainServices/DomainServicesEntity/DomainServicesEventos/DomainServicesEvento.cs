using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.DomainServices.DomainServicesBases;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEventos;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEventos;
using InfoAlexandre.Domain.Domain.Enum;
using System;
using System.Collections.Generic;

namespace InfoAlexandre.Domain.DomainServices.DomainServicesEntity.DomainServicesEventos
{
    public class DomainServicesEvento : DomainServicesBase<Eventos>, IContractsDomainServicesEvento
    {
        #region Atributos

        private IContractsSGBDEvento domainServicesEvento;

        #endregion

        #region Construtor

        public DomainServicesEvento(IContractsSGBDEvento domainServicesEvento)
            : base(domainServicesEvento)
        {
            this.domainServicesEvento = domainServicesEvento;
        }

        #endregion

        #region Implementação dos Métodos do Evento

        public Eventos PesquisarEventoPorNomeServices(string nome)
        {
            return domainServicesEvento.PesquisarEventoPorNomePersistence(nome);
        }

        public Eventos PesquisarEventoPorDataServices(DateTime data)
        {
            return domainServicesEvento.PesquisarEventoPorDataPersistence(data);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorCargaHorariaServices(int cargahoraria)
        {
            return domainServicesEvento.PesquisarEventosPorCargaHorariaPersistence(cargahoraria);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorCertificadoServices(bool certificado)
        {
            return domainServicesEvento.PesquisarEventosPorCertificadoPersistence(certificado);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorInstituicaoServices(string instituicao)
        {
            return domainServicesEvento.PesquisarEventosPorInstituicaoPersistence(instituicao);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorStatusServices(Status status)
        {
            return domainServicesEvento.PesquisarEventosPorStatusPersistence(status);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorTipoAulaServices(TipoAula tipoaula)
        {
            return domainServicesEvento.PesquisarEventosPorTipoAulaPersistence(tipoaula);
        }

        #endregion
    }
}