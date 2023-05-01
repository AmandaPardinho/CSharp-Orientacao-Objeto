using bytebank.Contas;
using bytebank.Titular;

////Teste criação da conta 1
//ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = "André Silva";
//contaAndre.numeroAgencia = 15;
//contaAndre.conta = "1010-X";
//contaAndre.saldo = 100.0;
//Console.WriteLine($"Saldo na conta do André = R$ {String.Format("{0:0.00}", contaAndre.saldo)}");

//ContaCorrente contaAndre2 = new ContaCorrente();
//contaAndre2.titular = "André Silva";
//contaAndre2.numeroAgencia = 15;
//contaAndre2.conta = "1010-X";
//contaAndre2.saldo = 100.0;
//Console.WriteLine($"Saldo na conta do André 2 = R$ {String.Format("{0:0.00}", contaAndre2.saldo)}");

////Console.WriteLine(contaAndre == contaAndre2);

////Teste método depositar
//contaAndre.Depositar(100);
//Console.WriteLine($"Saldo da conta do André após o depósito é de R$ {String.Format("{0:0.00}", contaAndre.saldo)}");

////Teste método sacar (com validação)
//if(contaAndre.Sacar(300) == true)
//{ Console.WriteLine($"Saldo atual {String.Format("{0:0.00}", contaAndre.saldo)}");
//}
//else
//{
//    Console.WriteLine($"Não foi possível realizar o saque pois saldo em conta é de R$ {String.Format("{0:0.00}", contaAndre.saldo)}");
//}

//Teste criação conta 2
//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Souza";
//contaMaria.numeroAgencia = 17;
//contaMaria.conta = "1010-5";
//contaMaria.saldo = 350.0;

//Console.WriteLine($"Saldo da conta da Maria = R$ {String.Format("{0:0.00}", contaMaria.saldo)}");

////Teste transferir
//contaAndre.Transferir(50, contaMaria);
//Console.WriteLine($"Novo saldo da conta da Maria = R$ {String.Format("{0:0.00}", contaMaria.saldo)}");
//Console.WriteLine($"Novo saldo da conta do André = R$ {String.Format("{0:0.00}", contaAndre.saldo)}");

////Teste criação conta 3
//ContaCorrente contaPedro = new ContaCorrente();
//contaPedro.titular = "Pedro Soares";

////Teste valor padrão dos campos (variáveis) criadas na classe ContaCorrente
//Console.WriteLine($"Nome do titular: {contaPedro.titular}\nNúmero da agência: {contaPedro.numeroAgencia}\nNúmero da conta: {contaPedro.conta}\nSaldo: {contaPedro.saldo}");

///*Tipagem por valor => compara valores
// * envolve tipos primitivos;
// * valor e valor2 não apontam para o mesmo endereço na memória => é criada uma cópia do conteúdo da variável valor para a variável valor2; porém, caso haja uma comparação entre eles para verificar se são iguais, o resultado será TRUE ;
// */
//double valor = 300;
//double valor2 = valor;
//Console.WriteLine(valor == valor2);

///*Tipagem por referência => compara endereços na memória
// * criação de um atalho como referência
// * necessário o uso da palavra reservada "new" e o nome do objeto que se quer criar;
// * necessário que haja uma referência para conseguir manipular o objeto em memória, acessar seus campos e métodos => criação, no computador, de um novo objeto; 
// *cada objeto tem um endereçamento único na memória e, por isso, ao compará-los para ver se são iguais, o resultado será FALSE;
// */

//Console.WriteLine(contaMaria.ExibirInfos());
/////////////////////////////////////////////////////////////

////Chamando a classe Cliente e a classe ContaCorrente
//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "12345678900";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100.0;

//Console.WriteLine(conta.ExibirInfos());
////ou
//Console.WriteLine();
//Console.WriteLine($"Nome: {conta.titular.nome}");
//Console.WriteLine($"CPF: {conta.titular.cpf}");
//Console.WriteLine($"Profissão: {conta.titular.profissao}");
////*********************\\

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "999888777-66";
//conta2.conta = "9999-X";
//conta2.numeroAgencia = 18;
//conta2.saldo = 500;

//Console.WriteLine();
//Console.WriteLine(conta2.ExibirInfos());

/* Manipulando uma variável "private"
 * - Ao definir uma variável como "private", seu acesso poderá ser realizado através de métodos públicos;
 * - Esta definição torna o código mais seguro;
 */
ContaCorrente conta3 = new ContaCorrente();
conta3.SetSaldo(100);
Console.WriteLine(conta3.GetSaldo());
//Trabalhando com propriedades
conta3.NumeroAgência = 18;
Console.WriteLine(conta3.NumeroAgência);

//Propriedade autoimplementada
conta3.Conta = "1011-H";
Console.WriteLine(conta3.Conta);

Console.ReadKey();