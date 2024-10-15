using Models;
//herencia

public class PlatoPrincipal : Producto {

    public string Ingredientes {get;set;}
//constructor añadiendo de base (padre) dos propiedades: precio y  nombre

public PlatoPrincipal(string nombre, double precio, string ingredientes): base(nombre, precio) {
   Ingredientes = ingredientes;
}
//importante!! override, sobreescribe por herencia
    public override void MostrarDetalles() {
        Console.WriteLine($"Plato principal: {Nombre}, Precio {Precio:C}, Ingredientes {Ingredientes} ");
    }
}