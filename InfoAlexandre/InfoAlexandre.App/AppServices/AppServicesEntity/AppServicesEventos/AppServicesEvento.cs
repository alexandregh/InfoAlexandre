using System;
using System.Collections.Generic;
using InfoAlexandre.App.AppServices.AppServicesBases;
using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEventos;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEventos;

namespace InfoAlexandre.App.AppServices.AppServicesEntity.AppServicesEventos
{
    public class AppServicesEvento : AppServicesBase<Eventos>, IContractsAppServicesEvento
    {
        #region Atributo

        private IContractsDomainServicesEvento appServicesEvento;

        #endregion

        #region Construtor

        public AppServicesEvento(IContractsDomainServicesEvento appServicesEvento)
            : base(appServicesEvento)
        {
            this.appServicesEvento = appServicesEvento;
        }

        #endregion

        #region Implementação dos Métodos de Evento

        public Eventos PesquisarEventoPorNomeApp(string nome)
        {
            return appServicesEvento.PesquisarEventoPorNomeServices(nome);
        }

        public Eventos PesquisarEventoPorDataApp(DateTime data)
        {
            return appServicesEvento.PesquisarEventoPorDataServices(data);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorCargaHorariaApp(int cargahoraria)
        {
            return appServicesEvento.PesquisarEventoPorCargaHorariaServices(cargahoraria);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorCertificadoApp(bool certificado)
        {
            return appServicesEvento.PesquisarEventoPorCertificadoServices(certificado);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorInstituicaoApp(string instituicao)
        {
            return appServicesEvento.PesquisarEventoPorInstituicaoServices(instituicao);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorStatusApp(Status status)
        {
            return appServicesEvento.PesquisarEventoPorStatusServices(status);
        }

        public IReadOnlyCollection<Eventos> PesquisarEventoPorTipoAulaApp(TipoAula tipoaula)
        {
            return appServicesEvento.PesquisarEventoPorTipoAulaServices(tipoaula);
        }

        #endregion
    }
}