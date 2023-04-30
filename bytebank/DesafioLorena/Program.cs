using desafiolorena.Comprador;
using desafiolorena.Pedidos;

Pedido pedido = new Pedido();
pedido.comprador = new Cliente();

pedido.comprador.nome = "Amanda Pardinho";
pedido.comprador.endereco = "Rua tal tal tal, número X - Bairro VcJaSabe";
pedido.numeroPedido = 1;
pedido.item = "Livro1, Livro 2, Livro3";
pedido.qtdItens = 3;
pedido.valorTotalPedido = 100.0;

Console.WriteLine($"Número do pedido: {pedido.numeroPedido}\nNome: {pedido.comprador.nome}\nEndereço: {pedido.comprador.endereco}\nItens: {pedido.item}\nTotal de itens: {pedido.qtdItens}\nTotal da compra: R$ {(String.Format("{0:0.00}", pedido.valorTotalPedido))}");

Console.ReadKey();

/* OBSERVAÇÃO:
 * - Seria possível criar mais classes, mas por ser só um exemplo, optei por criar apenas duas;
 * - Classes possíveis de serem criadas: Produtos, Endereço equalquer outra informação relativa a uma compra que fosse relevante
 */