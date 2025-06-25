using Builder;

HamburguerBuilder hamburguer = new();

// Hamburguer com carne de sol, pão brioche, com bacon, batata palha, queijo e salada
var carneSol = hamburguer.SetTipoPao("Brioche")
          .SetTipoCarne("Carne de Sol")
          .TemBacon()
          .TemBatataPalha()
          .TemQueijo()
          .TemSalada()
          .Build();

// Hamburguer com carne de frango, pão francês, com bacon e queijo
hamburguer = new();
var frango = hamburguer.SetTipoPao("Francês")
          .SetTipoCarne("Frango")
          .TemBacon()
          .TemQueijo()
          .Build();

Console.WriteLine("Descrição dos Hamburgueres:");
Console.WriteLine("=================================");
Console.WriteLine("Primeiro Pedido - Hamburguer de Carne de Sol:");
Console.WriteLine(carneSol.GetDescricao());
Console.WriteLine("=================================");
Console.WriteLine("Segundo Pedido - Hamburguer de Frango:");
Console.WriteLine(frango.GetDescricao());
