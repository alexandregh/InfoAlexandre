using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesBases;

namespace InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesAdministradores
{
    public interface IContractsDomainServicesAdministrador : IContractsDomainServicesBase<Administradores>
    {
        #region Interface dos Métodos do Administrador

        Administradores PesquisarAdministradorPorNomeServices(string nome);
        Administradores PesquisaAdministradorPorSobrenomeServices(string sobrenome);
        Administradores PesquisaAdministradorPorLoginSenhaServices(string login, string senha);

        #endregion
    }
}