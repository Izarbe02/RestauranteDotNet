using Models;

public class Postre : Producto {

    public int Calorias {get;set;}
    public bool ConAzucar {get;set;} = true;
    public bool ConGluten {get;set;}  = false;


//constructores
public Postre(string nombre, double precio, int calorias, bool conAzucar, bool conGluten): base(nombre, precio) {
   Calorias = calorias;
   ConAzucar = conAzucar;
}

    public override void MostrarDetalles() {
        string llevaAzucar = ConAzucar ? "Si" : "No";
        string llevaGluten = ConGluten ? "Si" : "No";
        Console.WriteLine($"Postre: {Nombre}, Precio {Precio:C}, Calorías {Calorias}, ¿Lleva Azúcar? {llevaAzucar}, ¿Lleva Gluten? {llevaGluten}");
    }
}