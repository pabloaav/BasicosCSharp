// Clase base Mamifero
public class Mamifero
{
   // Método virtual que puede ser sobrescrito
   public virtual void EmitirSonido()
   {
      Console.WriteLine("El mamífero hace un sonido.");
   }

   // Método normal, que no puede ser sobrescrito con override
   public void Comer()
   {
      Console.WriteLine("El mamífero está comiendo.");
   }
}

// Clase Humano que hereda de Mamifero
public class Humano : Mamifero
{
   // Sobrescritura del método virtual usando override
   public override void EmitirSonido()
   {
      Console.WriteLine("El humano habla.");
   }

   // Sobrescritura simple del método no virtual
   public new void Comer()
   {
      Console.WriteLine("El humano está comiendo.");
   }
}

// Clase Gorila que hereda de Mamifero
public class Gorila : Mamifero
{
   // Sobrescritura del método virtual usando override
   public override void EmitirSonido()
   {
      Console.WriteLine("El gorila gruñe.");
   }

   // Sobrescritura simple del método no virtual
   public new void Comer()
   {
      Console.WriteLine("El gorila está comiendo.");
   }
}

// Clase Caballo que hereda de Mamifero
public class Caballo : Mamifero
{
   // Sobrescritura del método virtual usando override
   public override void EmitirSonido()
   {
      Console.WriteLine("El caballo relincha.");
   }

   // Sobrescritura simple del método no virtual
   public new void Comer()
   {
      Console.WriteLine("El caballo está comiendo.");
   }
}

class Program
{
   static void Main()
   {

      // Lista de mamíferos
      List<Mamifero> mamiferos = new List<Mamifero>
        {
            new Humano(),
            new Gorila(),
            new Caballo()
        };

      // Demostración del polimorfismo
      foreach (Mamifero mamifero in mamiferos)
      {
         mamifero.EmitirSonido(); // Llamará al método sobrescrito en cada subclase
         mamifero.Comer(); // Llamará al método original en la clase Mamifero
      }

      Console.WriteLine();

      // Demostración de la sobrescritura simple
      Humano humano = new Humano();
      humano.EmitirSonido(); // Llamará al método sobrescrito en Humano
      humano.Comer(); // Llamará al método sobrescrito en Humano

      Gorila gorila = new Gorila();
      gorila.EmitirSonido(); // Llamará al método sobrescrito en Gorila
      gorila.Comer(); // Llamará al método sobrescrito en Gorila

      Caballo caballo = new Caballo();
      caballo.EmitirSonido(); // Llamará al método sobrescrito en Caballo
      caballo.Comer(); // Llamará al método sobrescrito en Caballo
   }
}
