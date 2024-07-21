class Program
{
   static void Main(string[] args)
   {
      // Crear instancia de Coche usando el constructor por defecto
      Coche coche1 = new Coche();
      coche1.MostrarInformacion();
      coche1.Acelerar();
      coche1.Frenar();

      // Crear instancia de Coche usando el constructor sobrecargado
      Coche coche2 = new Coche("Toyota", "Corolla", 2020);
      coche2.MostrarInformacion();
      coche2.Acelerar();
      coche2.Frenar();

      // Modificar propiedades del coche
      coche1.Marca = "Honda";
      coche1.Modelo = "Civic";
      coche1.Año = 2018;
      coche1.MostrarInformacion();
   }
}


public partial class Coche
{
   // Constructor por defecto
   public Coche()
   {
      Marca = "Desconocida";
      Modelo = "Desconocido";
      Año = 0;
   }

   // Constructor sobrecargado
   public Coche(string marca, string modelo, int año)
   {
      Marca = marca;
      Modelo = modelo;
      Año = año;
   }
}

public partial class Coche
{
   // Propiedades
   public string Marca { get; set; }
   public string Modelo { get; set; }
   public int Año { get; set; }

   // Métodos
   public void Acelerar()
   {
      Console.WriteLine($"{Marca} {Modelo} está acelerando.");
   }

   public void Frenar()
   {
      Console.WriteLine($"{Marca} {Modelo} está frenando.");
   }

   public void MostrarInformacion()
   {
      Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
   }
}

