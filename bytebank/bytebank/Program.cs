using bytebank;

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

//
Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "12345678900";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numeroAgencia = 15;
conta.saldo = 100.0;

Console.WriteLine(conta.ExibirInfos());
//ou
Console.WriteLine();
Console.WriteLine($"Nome: {conta.titular.nome}");
Console.WriteLine($"CPF: {conta.titular.cpf}");
Console.WriteLine($"Profissão: {conta.titular.profissao}");

Console.ReadKey();