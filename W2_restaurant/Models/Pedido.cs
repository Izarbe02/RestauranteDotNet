using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Models;

class Pedido //entidad por si sola
{
    private List<Producto> productos;

    public Pedido()
    {
        //inicializar variable producto
        productos = new List<Producto>();

    }

    public void AnadirProductos(Producto producto)
    {
        productos.Add(producto);
        Console.WriteLine($"Producto añadido: {producto.Nombre}");
    }
    public void MostrarPedido()
    {
        foreach (var Producto in productos)
        {
            Producto.MostrarDetalles();
        }
    }
    public double CalcularTotal()
    {
        double total = 0;
        foreach (var producto in productos)
        {
            total += producto.Precio;
        }
        return total;
    }
    //hay que pasar  el tipo de dato que se va a utilizar, en este 

    public double CalcularIva(double porcentajeIva)
        {
            double total = CalcularTotal();
            double iva = total * (porcentajeIva / 100);
            return iva;
        }

        // Método para calcular el total incluyendo IVA
        public double CalcularTotalConIva(double porcentajeIva)
        {
            double total = CalcularTotal();
            double iva = CalcularIva(porcentajeIva);
            return total + iva;
        }
}

