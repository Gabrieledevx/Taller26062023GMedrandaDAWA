using Microsoft.EntityFrameworkCore;
using Taller26062023GMedrandaDAWA.Models;

class Program
{
    static void Main(string[] args)
    {
        agregarCliente();
        consultarCliente();
        modificarCliente();
        eliminarCliente();
        consultarClienteFunciones();
    }

    //agregar estudiante
    public static void agregarCliente()
    {
        AplicationDbContext context = new AplicationDbContext();

        Console.WriteLine("Metodo agregar Cliente");
        Cliente user = new Cliente();
        user.Nombre = "AXY";
        user.Apellido = "MAPE";
        user.Direccion = "Colinas de la alborada";
        user.Telefono = "0999999999";
        user.Fecha_nac = "2001/02/02";
        user.Estado = true;
        context.Clientes.Add(user);
        context.SaveChanges();

        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Nombre);
    }

    public static void consultarCliente()
    {
        AplicationDbContext context = new AplicationDbContext();
        List<Cliente> listClientes = context.Clientes.ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Name: " + item.Nombre);
        }
    }

    public static void modificarCliente()
    {
        Console.WriteLine("Consultar Cliente por Id");
        AplicationDbContext context = new AplicationDbContext();
        Cliente user = new Cliente();
        user = context.Clientes.Find(1);

        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Nombre);
    }

    public static void eliminarCliente()
    {
        Console.WriteLine("Eliminar Cliente");
        AplicationDbContext context = new AplicationDbContext();
        Cliente user = new Cliente();
        user = context.Clientes.Find(5);
        context.Remove(user);
        context.SaveChanges();
        Console.WriteLine("Codigo: " + user.Id + " Name: " + user.Nombre);
    }

    public static void consultarClienteFunciones()
    {
        Console.WriteLine("Consultar CLiente");
        AplicationDbContext context = new AplicationDbContext();
        List<Cliente> listClientes;
        Console.WriteLine("Cantidad de registros: " + context.Clientes.Count());
        Cliente user = context.Clientes.First();
        Console.WriteLine("Primer elemento de la tabla:" + user.Id + "-" + user.Nombre);
        listClientes = context.Clientes.Where(s => s.Name.StartsWith("A")).ToList();

        foreach (var item in listClientes)
        {
            Console.WriteLine("Codigo: " + item.Id + " Name: " + item.Nombre);
        }
    }
}