
using Models;

var platoPrincipal = new PlatoPrincipal("Plato combinado", 12.50, "Pollo, patatas, tomate");
platoPrincipal.MostrarDetalles();

var bebida = new Bebida("Segarro", 1.50, false);
bebida.MostrarDetalles();

var postre = new Postre("Tiramisú", 7.00, 800, true, true);
postre.MostrarDetalles();

var pedido = new Pedido();
pedido.AnadirProductos(platoPrincipal);
pedido.AnadirProductos(bebida);
pedido.AnadirProductos(postre);

//pedido.MostrarPedido();

var total = pedido.CalcularTotal();
Console.WriteLine($"Total pedido: {total}");

var combo = new Combo(platoPrincipal,bebida,postre,0.10);
combo.MostrarDetalles();


pedido.AnadirProductos(combo,3);
pedido.MostrarPedido();
var totalConCantidad = pedido.CalcularTotal();
Console.WriteLine($"Total pedido: {totalConCantidad}");



//var menuApp = new MenuApp();
//menuApp.MostrarMenu();