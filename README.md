# Vunesp.Pagamento
Mock para o módulo de pagamentos

## Arquitetura
Baseada na nova arquitetura do site com melhorias. Nova solution dividida em 5 projetos iniciais:

- Vunesp.Pagamento.Model
- Vunesp.Pagamento.Repositorio
- Vunesp.Pagamento.Domain
- Vunesp.Pagamento.Dto
- Vunesp.Pagamento.Api

### Vunesp.Pagamento.Model
Classes para representar o modelo do negócio (provavelmente a tabela CandidatoProjetoPagamento), conforme já é hoje porém sem nenhuma implementação de métodos, apenas propriedades.

### Vunesp.Pagamento.Repositorio
Acesso a dados, substituição do antigo "Data" porém sem classes estáticas para possibilitar implementação de interfaces, injeção de dependência e testes unitários. Não deve conter nenhuma regra de negócio.

### Vunesp.Pagamento.Domain
Implementa regras de negócio e validações do modelo e chama os métodos do repositório. É aonde deve ficar a parte lógica da aplicação.

### Vunesp.Pagamento.Dto
Classes que serão expostas e consumidas/recebidas pela API, representam na prática entidades muito parecidas com o model porém mais simples para possibilitar o isolamento do model e uma melhor serialização. Parecido com o conceito de Model e ViewModel, aqui tem uma explicação muito boa:

https://pt.stackoverflow.com/a/31365

### Vunesp.Pagamento.Api
Web API em ASP.NET Core que irá ser efetivamente consumida, consultando o domínio e retornando os DTO's em JSON.
