# Projeto Conta Bancária em C#

Este é um projeto de Conta Bancária desenvolvido em C# que coloca em prática os seguintes conceitos:

- Entrada e saída de dados
- Collections
- Estrutura de dados
- Classe abstrata
- Encapsulamento
- Herança
- Polimorfismo

O projeto simula um sistema bancário que permite aos usuários realizar as seguintes operações (CRUD):

- Criar contas
- Listar contas
- Atualizar contas
- Apagar contas

Além disso, o sistema também simula:

- Saques
- Depósitos
- Transferências entre contas
- Consulta de conta pelo titular

## Estrutura do Projeto

O projeto está organizado da seguinte forma:

- `ContaBancaria.cs`: Implementa a classe base `ContaBancaria`, que serve como classe abstrata para as diferentes contas bancárias.
- `ContaCorrente.cs` e `ContaPoupanca.cs`: Implementam classes derivadas de `ContaBancaria` que representam contas correntes e poupanças, respectivamente.
- `Banco.cs`: Gerencia todas as operações de conta e mantém um registro das contas existentes.
- `Program.cs`: Contém o programa principal que interage com o usuário, permitindo executar as operações mencionadas acima.

## Como Usar

1. Clone este repositório para o seu ambiente de desenvolvimento local:

   ```bash
   git clone https://github.com/EduSerodio/ProjetoContaBancaria.git
   ```
   
   2. Abra o projeto em um ambiente de desenvolvimento C# compatível (por exemplo, Visual Studio).

   3. Compile e execute o projeto.

   4. Siga as instruções no programa principal para criar, listar, atualizar e apagar contas, além de realizar saques, depósitos, transferências e consultas de conta por titular.

## Contribuições

Este é um projeto simples criado com fins educacionais para demonstrar a aplicação de conceitos de programação em C#. Contribuições são bem-vindas. Sinta-se à vontade para abrir problemas (issues) ou enviar solicitações de pull (pull requests) com melhorias, correções de bugs ou novos recursos.

Aproveite o projeto e explore os conceitos de programação orientada a objetos e manipulação de dados em C#. Divirta-se codificando!

Se tiver alguma dúvida ou precisar de assistência, sinta-se à vontade para entrar em contato.



