using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDBases;

namespace InfoAlexandre.Domain.IContracts.IContractsSGBD.IContractsSGBD.IContractsSGBDEntity.IContractsSGBDAdministradores
{
    public interface IContractsSGBDAdministrador : IContractsSGBDBase<Administradores>
    {
        #region Interface dos Métodos do Administrador

        Administradores PesquisarAdministradorPorNomePersistence(string nome);
        Administradores PesquisaAdministradorPorSobrenomePersistence(string sobrenome);
        Administradores PesquisaAdministradorPorLoginSenhaPersistence(string login, string senha);

        #endregion
    }
}