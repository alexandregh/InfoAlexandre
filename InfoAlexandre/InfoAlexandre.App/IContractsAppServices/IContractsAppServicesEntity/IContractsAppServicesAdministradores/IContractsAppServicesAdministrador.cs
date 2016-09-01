using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesBases;
using InfoAlexandre.Domain.Domain.Entity;

namespace InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAdministradores
{
    public interface IContractsAppServicesAdministrador : IContractsAppServicesBase<Administradores>
    {
        #region Interface dos Métodos do Administrador

        Administradores PesquisarAdministradorPorNomeApp(string nome);
        Administradores PesquisaAdministradorPorSobrenomeApp(string sobrenome);
        Administradores PesquisaAdministradorPorLoginSenhaApp(string login, string senha);

        #endregion
    }
}