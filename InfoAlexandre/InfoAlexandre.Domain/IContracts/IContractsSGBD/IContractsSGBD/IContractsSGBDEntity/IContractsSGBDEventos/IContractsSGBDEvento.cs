using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDBases;
using System;
using System.Collections.Generic;

namespace InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDEventos
{
    public interface IContractsSGBDEvento : IContractsSGBDBase<Eventos>
    {
        #region Interface dos Métodos dos Eventos

        Eventos PesquisarEventoPorNomePersistence(string nome);
        Eventos PesquisarEventoPorDataPersistence(DateTime data);
        IReadOnlyCollection<Eventos> PesquisarEventosPorInstituicaoPersistence(string instituicao);
        IReadOnlyCollection<Eventos> PesquisarEventosPorCargaHorariaPersistence(int cargahoraria);
        IReadOnlyCollection<Eventos> PesquisarEventosPorTipoAulaPersistence(TipoAula tipoaula);
        IReadOnlyCollection<Eventos> PesquisarEventosPorCertificadoPersistence(bool certificado);
        IReadOnlyCollection<Eventos> PesquisarEventosPorStatusPersistence(Status status);

        #endregion
    }
}