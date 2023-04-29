using bytebank;

//Teste criação da conta 1
ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André Silva";
contaAndre.numeroAgencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100.0;

Console.WriteLine($"Saldo na conta do André = R$ {String.Format("{0:0.00}", contaAndre.saldo)}");

//Teste método depositar
/*contaAndre.Depositar(100);
Console.WriteLine($"Saldo da conta do André após o depósito é de R$ {String.Format("{0:0.00}", contaAndre.saldo)}");

//Teste método sacar (com validação)
if(contaAndre.Sacar(300) == true)
{ Console.WriteLine($"Saldo atual {String.Format("{0:0.00}", contaAndre.saldo)}");
}
else
{
    Console.WriteLine($"Não foi possível realizar o saque pois saldo em conta é de R$ {String.Format("{0:0.00}", contaAndre.saldo)}");
}*/

//Teste criação conta 2
ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Souza";
contaMaria.numeroAgencia = 17;
contaMaria.conta = "1010-5";
contaMaria.saldo = 350.0;

Console.WriteLine($"Saldo da conta da Maria = R$ {String.Format("{0:0.00}", contaMaria.saldo)}");

//Teste transferir
contaAndre.Transferir(50, contaMaria);
Console.WriteLine($"Novo saldo da conta da Maria = R$ {String.Format("{0:0.00}", contaMaria.saldo)}");
Console.WriteLine($"Novo saldo da conta do André = R$ {String.Format("{0:0.00}", contaAndre.saldo)}");

//Teste criação conta 3
ContaCorrente contaPedro = new ContaCorrente();
contaPedro.titular = "Pedro Soares";

//Teste valor padrão dos campos (variáveis) criadas na classe ContaCorrente
Console.WriteLine($"Nome do titular: {contaPedro.titular}\nNúmero da agência: {contaPedro.numeroAgencia}\nNúmero da conta: {contaPedro.conta}\nSaldo: {contaPedro.saldo}");

Console.ReadKey();