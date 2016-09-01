using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesBases;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using System;
using System.Collections.Generic;

namespace InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesEventos
{
    public interface IContractsAppServicesEvento : IContractsAppServicesBase<Eventos>
    {
        #region Interface dos Métodos do Evento

        Eventos PesquisarEventoPorNomeApp(string nome);
        Eventos PesquisarEventoPorDataApp(DateTime data);
        IReadOnlyCollection<Eventos> PesquisarEventoPorInstituicaoApp(string instituicao);
        IReadOnlyCollection<Eventos> PesquisarEventoPorCargaHorariaApp(int cargahoraria);
        IReadOnlyCollection<Eventos> PesquisarEventoPorTipoAulaApp(TipoAula tipoaula);
        IReadOnlyCollection<Eventos> PesquisarEventoPorCertificadoApp(bool certificado);
        IReadOnlyCollection<Eventos> PesquisarEventoPorStatusApp(Status status);

        #endregion
    }
}