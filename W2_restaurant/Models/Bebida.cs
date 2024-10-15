using Models;
//herencia de abstract
public class Bebida : Producto {

    public bool EsAlcoholica {get;set;}  //

public Bebida(string nombre, double precio, bool esAlcoholica): base(nombre, precio) {
   EsAlcoholica = esAlcoholica;
}

    public override void MostrarDetalles() {
        string llevaAlcohol = EsAlcoholica ? "Sí" : "No";
        Console.WriteLine($"Bebida: {Nombre}, Precio {Precio:C}, ¿Es alcohólica? {llevaAlcohol} ");
   //Precio {Precio:C} -----> ( :c pone símbolo de leuro)

    }
}