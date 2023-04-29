using bytebank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André Silva";
contaAndre.numeroAgencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100.0;

Console.WriteLine($"Saldo na conta do André = {contaAndre.saldo}");

contaAndre.Depositar(100);
Console.WriteLine($"Saldo da conta do André após o depósito é de R$ {contaAndre.saldo},00");

Console.ReadKey();