using System;
using System.Collections.Generic;
using InfoAlexandre.App.AppServices.AppServicesBases;
using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesCursos;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.Domain.Domain.Enum;
using InfoAlexandre.Domain.IContracts.IContractsDomainServices.IContractsDomainServicesEntity.IContractsDomainServicesCursos;

namespace InfoAlexandre.App.AppServices.AppServicesEntity.AppServicesCursos
{
    public class AppServicesCurso : AppServicesBase<Cursos>, IContractsAppServicesCurso
    {
        #region Atributo

        private IContractsDomainServicesCurso appServicesCurso;

        #endregion

        #region Construtor

        public AppServicesCurso(IContractsDomainServicesCurso appServicesCurso)
            : base(appServicesCurso)
        {
            this.appServicesCurso = appServicesCurso;
        }

        #endregion

        #region Implementação dos Métodos do Curso

        public Cursos PesquisarCursoPorNomeServices(string nome)
        {
            return appServicesCurso.PesquisarCursoPorNomeServices(nome);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorCargaHorariaApp(int cargahoraria)
        {
            return appServicesCurso.PesquisarCursosPorCargaHorariaServices(cargahoraria);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorCertificadoApp(bool certificado)
        {
            return appServicesCurso.PesquisarCursosPorCertificadoServices(certificado);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorInstituicaoApp(string instituicao)
        {
            return appServicesCurso.PesquisarCursosPorInstituicaoServices(instituicao);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorStatusApp(Status status)
        {
            return appServicesCurso.PesquisarCursosPorStatusServices(status);
        }

        public IReadOnlyCollection<Cursos> PesquisarCursosPorTipoAulaApp(TipoAula tipoaula)
        {
            return appServicesCurso.PesquisarCursosPorTipoAulaServices(tipoaula);
        }

        #endregion
    }
}