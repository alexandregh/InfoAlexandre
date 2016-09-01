using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;
using System;
using System.Collections.Generic;

namespace InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesEventos
{
    public interface IContractsDomainServicesEvento : IContractsDomainServicesBase<Eventos>
    {
        #region Interface dos Métodos do Evento

        Eventos PesquisarEventoPorNomeServices(string nome);
        Eventos PesquisarEventoPorDataServices(DateTime data);
        IReadOnlyCollection<Eventos> PesquisarEventoPorInstituicaoServices(string instituicao);
        IReadOnlyCollection<Eventos> PesquisarEventoPorCargaHorariaServices(int cargahoraria);
        IReadOnlyCollection<Eventos> PesquisarEventoPorTipoAulaServices(TipoAula tipoaula);
        IReadOnlyCollection<Eventos> PesquisarEventoPorCertificadoServices(bool certificado);
        IReadOnlyCollection<Eventos> PesquisarEventoPorStatusServices(Status status);

        #endregion
    }
}