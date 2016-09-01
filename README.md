# InfoAlexandre
### Sistema Web - InfoAlexandre
###### Versão 1.0

###### Descrição:
<p>Projeto Web de um Sistema de Páginas Pessoal (Portfólio Pessoal) chamado InfoAlexandre.</p>
<p>O Sistema consiste no Gerenciamento de todas as funcionalidades do portfólio pessoal providas pelo sistema por parte de um único Usuário (Administrador) que gerencia e disponibiliza seus dados pessoais e profissionais.</p>

###### Detalhes Técnicos:
- Projeto: ASP NET
- Linguagem: C#
- Tecnologias Back-End: WebAPI + ORM Entity Framework - E.F (Fluent API) + Micro ORM Dapper + Ninject + AutoMapper;
- Tecnologias Front-End: AngularJS + HTML5 + CSS3 + JQquery + BootStrap;
- Base de Dados: SQLServer (.mdf);
- Divisão do Projeto: a solução do sistema está dividida em dois projetos separados e integrados entre si sendo eles:<br />
- Projeto Back-End;
- Projeto Front-End.
- Arquitetura do Projeto Back-End: a arquitetura do projeto Back-End atualmente está criada em DDD - Domain Driven Design contendo sete camadas descritas abaixo: <br />
**InfoAlexandre.WebApi:** Camada de construção e exposição de serviços HTTP que possibilita o acesso e consumo de forma direta desses serviços via Rest. Uma ampla variedade de dispositivos (browser, mobile, etc.) podem consumir esses serviços de forma simples e prática.<br />
**InfoAlexandre.App:** Camada de Aplicação responsável pela comunicação entre a camada acima (InfoAlexandre.WebApi) e o sistema propriamente dito. É uma camada fina de intercâmbio entre os serviços HTTP e o sistema onde uma solicitação de um usuário e requisitada ao sistema e, por sua vez, retornada pelo próprio sistema através do protocolo HTTP.<br />
**InfoAlexandre.Domain:** Camada de Domínio responsável por todas as Entidades (Objetos) de Negócio da Aplicação, bem como suas Regras de Domínio como Associações e Restrições. Essa camada contém todos os elementos necessários do Domínio da Aplicação como as Interfaces (Interface), Classes (Class), Enumerações (Enum), Relacionamentos (Relationship), Serviços de Domínio (DomainServices) e outros elementos;<br />
**InfoAlexandre.SGBD:** Camada de Repositório de Dados baseada em um Sistema de Gerenciamento de Banco de Dados onde sua finalidade é acessar, manipular e persistir todos os dados da aplicação;<br />
**InfoAlexandre.Ninject:** Camada de mapeamento que contém o Ninject (Injeção de Dependências). "O NInject é um container para Injeção de Dependência que procura oferecer uma alternativa simples para a implementação deste padrão. Busca com isto a obtenção de softwares constituídos de componentes com alta coesão e com um baixo acoplamento entre si.". *Fonte: http://www.devmedia.com.br/injecao-de-dependencia-com-ninject-artigo-revista-net-magazine-87/21605*<br />
**InfoAlexandre.Security:** Camada de Segurança dos Dados de cada usuário responsável, por exemplo, pela criptografia das senhas de todos os usuários cadastrados no sistema afim que os mesmos possam cadastrá-las, alterá-las e realizar seu login no sistema de forma segura; Essa camada baseada no conceito **Cross-Cutting Concerns** e responsável pelas Operações Utilitárias do Sistema;<br />
**InfoAlexandre.Convertions:** Camada de Conversão de Dados onde um de seus objetivos é realizar a conversão dos dados de entrada no sistema fornecidos por cada solicitação HTTP do usuário (administrador) cadastrado afim de que esses dados possam ser persistidos (criados ou alterados) no sistema de forma correta permitindo a integridade e regras e segurança dos dados no sistema.<br />
- Organização do Projeto: na IDE do Visual Studio a organização do projeto está dividida da seguinte forma:<br />
**1 - Sistema InfoAlexandre**<br />
**1.1 - Camada de Serviço Web**<br />
**1.2 - Camada de Aplicação**<br />
**1.3 - Camada de Domínio**<br />
**1.4 - Camada de Infraestrutura**<br />
**1.4.1 - Camada de Repositório**<br />
**1.4.1.1 - Camada de Banco de Dados**<br />
**1.4.2 - Camada de Mapeamentos**<br />
**1.4.2.1 - Camada de Mapeamento Ninject**<br />
**1.4.3 - Camada de Utilitários**<br />
**1.4.3.1 - Camada de Segurança**<br />
**1.4.3.2 - Camada de Conversão e Tratamento dos Dados**<br /><br />
**Cross-Cutting Concerns**: São funcionalidades que não estão diretamente relacionadas ao domínio da aplicação ou às suas respectivas regras de negócio, mas que ainda sim, são importantes para o Software. Exemplos: envio de emails, criptografia de senhas, etc.<br />
**Observação**: Durante o desenvolvimento da aplicação foi utilizada uma ferramenta do Visual Studio para análise estática de código chamada **Code Analysis**.
